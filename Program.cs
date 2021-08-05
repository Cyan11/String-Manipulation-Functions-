using System;
using System.Collections.Generic ;


namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstNonRepeatingChar(Console.ReadLine()));
        }
        static char FirstNonRepeatingChar(string s)
        {
            List<char> repeated = new List<char>();
            List<char> endList = new List<char>();
            foreach (char c in s)
            {
                if (repeated.Contains(c))
                {
                    endList.Remove(c);
                }
                else
                {
                    repeated.Add(c);
                    endList.Add(c);
                }
            }
            return endList[0];
        }
    }
}
