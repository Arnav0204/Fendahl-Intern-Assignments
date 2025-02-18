using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        // ------- Task 1: Reverse a String -------
        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // ------- Task 2: Count Vowels in a String -------
        static int CountVowels(string input)
        {
            int count = 0;
            string vowels = "aeiouAEIOU";
            foreach (char c in input)
            {
                if (vowels.Contains(c))
                    count++;
            }
            return count;
        }

        // ------- Task 3: Palindrome Check -------
        static bool IsPalindrome(string input)
        {
            int left = 0, right = input.Length - 1;
            while (left <= right)
            {
                if (char.ToLower(input[left]) != char.ToLower(input[right]))
                    return false;
                left++;
                right--;
            }
            return true;
        }

        // ------- Task 4: Find All Substrings -------
        static void PrintSubstrings(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j <= input.Length; j++)
                {
                    Console.WriteLine(input.Substring(i, j - i));
                }
            }
        }

        // ------- Task 5: Character Frequency Count -------
        static void CharFrequency(string input)
        {
            int[] freq = new int[256]; // Assuming extended ASCII character set

            foreach (char c in input)
            {
                freq[c]++; // Increment the count for the character
            }

            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] > 0)
                {
                    Console.WriteLine($"{(char)i}: {freq[i]}");
                }
            }
        }


        // ------- Task 6: Replace a Character in a String -------
        static string ReplaceCharacter(string input, char oldChar, char newChar)
        {
            return input.Replace(oldChar, newChar);
        }

        // ------- Task 7: String Comparison (Case-Insensitive) -------
        static bool CompareStrings(string str1, string str2)
        {
            return string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase);
        }

        // ------- Task 8: Find the Longest Word in a Sentence -------
        static string LongestWord(string sentence)
        {
            string[] words = sentence.Split(' ');
            string longest = "";
            foreach (string word in words)
            {
                if (word.Length > longest.Length)
                    longest = word;
            }
            return longest;
        }

        // ------- Task 9: Remove Whitespace from a String -------
        static string RemoveWhitespace(string input)
        {
            return input.Trim();
        }

        // ------- Task 10: Check for Anagrams -------
        static bool AreAnagrams(string str1, string str2)
        {
            if (str1.Length != str2.Length) return false;

            Dictionary<char, int> freq1 = new Dictionary<char, int>();
            Dictionary<char, int> freq2 = new Dictionary<char, int>();

            foreach (char c in str1)
            {
                if (freq1.ContainsKey(c)) freq1[c]++;
                else freq1[c] = 1;
            }

            foreach (char c in str2)
            {
                if (freq2.ContainsKey(c)) freq2[c]++;
                else freq2[c] = 1;
            }

            return freq1.Count == freq2.Count && !freq1.Except(freq2).Any();
        }

        // ------- Task 11: Count Words in a Sentence -------
        static int CountWords(string sentence)
        {
            string[] words = sentence.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        // ------- Task 12: Split a Sentence into Words -------
        static void SplitSentence(string sentence)
        {
            string[] words = sentence.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }

        // ------- Main Method to Execute Tasks -------
        static void Main()
        {
            Console.WriteLine("------- Task 1: Reverse String -------");
            Console.WriteLine(ReverseString("hello"));

            Console.WriteLine("\n------- Task 2: Count Vowels -------");
            Console.WriteLine(CountVowels("Hello World"));

            Console.WriteLine("\n------- Task 3: Is Palindrome? -------");
            Console.WriteLine(IsPalindrome("racecar"));

            Console.WriteLine("\n------- Task 4: All Substrings of 'abc' -------");
            PrintSubstrings("abc");

            Console.WriteLine("\n------- Task 5: Character Frequency in 'hello' -------");
            CharFrequency("hello");

            Console.WriteLine("\n------- Task 6: Replace 'a' with 'o' in 'banana' -------");
            Console.WriteLine(ReplaceCharacter("banana", 'a', 'o'));

            Console.WriteLine("\n------- Task 7: Compare 'hello' and 'HELLO' -------");
            Console.WriteLine(CompareStrings("hello", "HELLO"));

            Console.WriteLine("\n------- Task 8: Longest Word in 'The quick brown fox jumps' -------");
            Console.WriteLine(LongestWord("The quick brown fox jumps"));

            Console.WriteLine("\n------- Task 9: Remove Whitespace -------");
            Console.WriteLine("'" + RemoveWhitespace("  hello world  ") + "'");

            Console.WriteLine("\n------- Task 10: Are 'listen' and 'silent' anagrams? -------");
            Console.WriteLine(AreAnagrams("listen", "silent"));

            Console.WriteLine("\n------- Task 11: Count Words in 'C# is fun' -------");
            Console.WriteLine(CountWords("C# is fun"));

            Console.WriteLine("\n------- Task 12: Splitting Sentence 'C# is great!' -------");
            SplitSentence("C# is great!");
        }
    }
}
