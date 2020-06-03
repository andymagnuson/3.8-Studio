using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _3._8_Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter string to be tested");
            string inputStr = Console.ReadLine();
            char temp = 'x';
            Dictionary<char, int> totalCount = new Dictionary<char, int>();

            do
            {
                temp = inputStr[0];
               inputStr = inputStr.Remove(0,1);
                if (totalCount.ContainsKey(temp))
                {
                    totalCount[temp] += 1;
                }
                else
                {

                    totalCount.Add(temp, 1);
                }
            }
            while (inputStr.Length>0);



            foreach (KeyValuePair<char, int> x in totalCount)
            {
                Console.WriteLine($"{ x.Key}: { x.Value}");

            }
          
        }
    }
}
