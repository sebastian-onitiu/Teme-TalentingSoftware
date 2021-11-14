using System;

namespace Tema1_Onitiu
{
    class Program
    {
        public static bool Verification(string message)
        {
            bool[] letters = new bool[26];
            int count = 0;

            for (int i = 0; i < message.Length; i++)
            {
                if ('A' <= message[i] && message[i] <= 'Z')
                    count = message[i] - 'A';

                else if ('a' <= message[i] && message[i] <= 'z')
                    count = message[i] - 'a';

                else continue;

                letters[count] = true;
            }

            for (int i = 0; i <= 25; i++)
                if (letters[i] == false)
                    return false;

            return true;

        }

        static void Main(string[] args)
        {
            // "The quick brown fox jumps over the lazy dog";
            string s = Console.ReadLine();

            if (Verification(s) == true)
                Console.WriteLine("PANGRAM");
            else
                Console.WriteLine("NOT PANGRAM");

        }
    }
}
