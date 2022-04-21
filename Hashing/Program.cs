using System;

namespace Hashing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Password hashing and checking test porogram pls press Enter...");
            Console.ReadLine();

            Console.Write("Input Password: ");
            string? password = Console.ReadLine();
            hashing.HashAndStore(password, @"C:\Users\(Your User)\Desktop\Hashing\Hashing\passwords.txt");

            Console.WriteLine();

            Console.Write("Input Text to Hash: ");
            string? input = Console.ReadLine();
            hashing.HashAndCheck(input, @"C:\Users\(Your User)\Desktop\Hashing\Hashing\checkpasswords.txt");
        }
    }
}