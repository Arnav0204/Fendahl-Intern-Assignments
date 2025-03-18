using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeApplicationLogger
{
    interface ILogger
    {
        void logInfo(string message);
        void logError(string message);
        void logWarning(string message);
    }

    class ConsoleLogger : ILogger
    {
        private FileWriter logWriter;
        public ConsoleLogger(FileWriter writer) { 
            this.logWriter = writer;
        }
        public void logInfo(string message)
        {
            Console.WriteLine($"Log info of console Log : {message}");
            this.logWriter.writeToFile(message);
        }
        public void logError(string message)
        {
            Console.WriteLine($"Log error of console Log : {message}");
            this.logWriter.writeToFile(message);
        }
        public void logWarning(string message)
        {
            Console.WriteLine($"Log warning of console Log : {message}");
            this.logWriter.writeToFile(message);
        }
    }

    class FileLogger : ILogger
    {
        private FileWriter logWriter;
        public FileLogger(FileWriter writer)
        {
            this.logWriter = writer;
        }
        public void logInfo(string message)
        {
            Console.WriteLine($"Log info of file Log : {message}");
            this.logWriter.writeToFile(message);
        }
        public void logError(string message)
        {
            Console.WriteLine($"Log error of file Log : {message}");
            this.logWriter.writeToFile(message);
        }
        public void logWarning(string message)
        {
            Console.WriteLine($"Log warning of file Log : {message}");
            this.logWriter.writeToFile(message);
        }
    }

    class CloudLogger : ILogger
    {
        private FileWriter logWriter;
        public CloudLogger(FileWriter writer)
        {
            this.logWriter = writer;
        }
        public void logInfo(string message)
        {
            Console.WriteLine($"Log info of cloud Log : {message}");
            this.logWriter.writeToFile(message);
        }
        public void logError(string message)
        {
            Console.WriteLine($"Log error of cloud Log : {message}");
            this.logWriter.writeToFile(message);
        }
        public void logWarning(string message)
        {
            Console.WriteLine($"Log warning of cloud Log : {message}");
            this.logWriter.writeToFile(message);
        }
    }

    internal class FileWriter
    {
        private string fileLocation = "";
        private string docPath = "";

        public void writeToFile(string message)
        {
            if (string.IsNullOrEmpty(docPath))
            {
                Console.WriteLine("File location is not set. Call setLocation() first.");
                return;
            }

            string filePath = Path.Combine(docPath, $"logs.txt");

            try
            {
                using (StreamWriter outputFile = new StreamWriter(filePath, true))
                {
                    outputFile.WriteLine(message);
                }
                Console.WriteLine("Message written to file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to file: {ex.Message}");
            }
        }

        public void setLocation()
        {
            Console.Write("Enter location for Log File: ");
            this.fileLocation = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(fileLocation) && Directory.Exists(fileLocation))
            {
                this.docPath = fileLocation;
            }
            else
            {
                Console.WriteLine("Invalid path. Using default location (My Documents).");
                this.docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            FileWriter logWriter = new FileWriter();
            logWriter.setLocation();
        ILogger consoleLogger = new ConsoleLogger(logWriter);
        consoleLogger.logInfo("console log info");
            consoleLogger.logWarning("console log warning");
            consoleLogger.logError("console log error");
            ILogger fileLogger = new FileLogger(logWriter);
        fileLogger.logInfo("file log info");
            fileLogger.logWarning("file log warning");
            fileLogger.logError("file log error");
            ILogger cloudLogger = new CloudLogger(logWriter);
        cloudLogger.logInfo("cloud log info");
            cloudLogger.logWarning("cloud log warning");
            cloudLogger.logError("cloud log error");
        }
    }
}
