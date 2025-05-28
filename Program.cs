//. Given two strings s and t, return true if t is an anagram of s, and false otherwise.

using System.Diagnostics.Tracing;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter First Word (s): ");
            string s = Console.ReadLine();

            Console.WriteLine(" Enter Second Word (t): ");
            string t = Console.ReadLine();

            if (s.Length != t.Length)
            {
                Console.WriteLine(" False, Not an Anagram!");
                return;
            }
            //converting to arrays 
            char[] sChars = s.ToCharArray();
            char[] tChars = t.ToCharArray();

            // sorting both arrays 
            Array.Sort(sChars);
            Array.Sort(tChars);

            bool isAnagram = sChars.SequenceEqual(tChars);

            Console.WriteLine(isAnagram ? "True (Anagram)" : "False (Not an Anagram)");

        }
    }
}