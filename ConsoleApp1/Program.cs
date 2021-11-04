using System;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string? message =  null;
            PrintMessage(message);
            int length = message!.Length; // dereferencing "message"
            Console.WriteLine("Hello World!");
        }
        public static bool PrintMessage([NotNullWhen(false)] string message)
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                Console.WriteLine($"{DateTime.Now}: {message}");
                return false;
            }
            return true;
        }
    }
}
