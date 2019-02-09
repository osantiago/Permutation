using System;

namespace IsPermutation
{
    class Program
    {
        static bool IsPermutation(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }

            foreach (var item in s1)
            {
                if (!s2.Contains(item))
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(IsPermutation("acdf", "dfac"));
        }
    }
}
