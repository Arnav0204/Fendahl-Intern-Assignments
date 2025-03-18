using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsExample
{
    internal class Program
    {
        static ConcurrentDictionary<string, int> wordCount = new ConcurrentDictionary<string, int>();
        static object lockObject = new object(); // Lock for thread safety

        static void ProcessFile(object filePath)
        {
            string path = (string)filePath;
            Console.WriteLine($"[Thread {Thread.CurrentThread.ManagedThreadId}] Processing {Path.GetFileName(path)}...");

            try
            {
                string text = File.ReadAllText(path);
                string[] words = Regex.Split(text.ToLower(), @"\W+"); 

                foreach (string word in words.Where(w => w.Length > 0))
                {
                    lock (lockObject) 
                    {
                        wordCount.AddOrUpdate(word, 1, (key, oldValue) => oldValue + 1);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Thread {Thread.CurrentThread.ManagedThreadId}] Error processing {path}: {ex.Message}");
            }
        }

        static void Main()
        {
            string folderPath = "C:\\Users\\HP\\Desktop\\input"; // Folder containing text files
            if (!Directory.Exists(folderPath))
            {
                Console.WriteLine("Folder not found.");
                return;
            }

            string[] files = Directory.GetFiles(folderPath, "*.txt");
            if (files.Length == 0)
            {
                Console.WriteLine("No text files found.");
                return;
            }

            Console.WriteLine("Starting multi-threaded word frequency count...\n");

            Thread[] threads = new Thread[files.Length];

            for (int i = 0; i < files.Length; i++)
            {
                threads[i] = new Thread(new ParameterizedThreadStart(ProcessFile));
                threads[i].Start(files[i]);
            }

            foreach (Thread thread in threads)
            {
                thread.Join(); // Wait for all threads to complete
            }

            Console.WriteLine("\nWord frequencies:");
            foreach (var kvp in wordCount.OrderByDescending(kvp => kvp.Value).Take(10))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }

}
