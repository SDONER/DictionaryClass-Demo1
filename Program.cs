using System;
using System.Collections.Generic;

namespace DictionaryClass_Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> ad = new Dictionary<string, int>();

            ad.Add("Ahmet",21);
            ad.Add("Sinem",23);
            ad.Add("Gamze",25);
            ad.Add("Serpil",29);

            foreach (var readItem in ad)
            {
                Console.WriteLine(readItem);
            }

            
        }
    }
}
