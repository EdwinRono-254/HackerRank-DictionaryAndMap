using System;
using System.Collections.Generic;

namespace HackerRank_DictionaryAndMap
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your
        class should be named Solution */

            int n = Convert.ToInt32(Console.ReadLine().Trim());
            Dictionary<string, string> phonebook = new Dictionary<string,string>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                phonebook[line[0]] = line[1];
            }
            Check_name(phonebook);
        }

        static void Check_name(Dictionary<string, string> phonebook)
        {
            string name;
            while ((name = Console.ReadLine()) != null && name.Length > 0)
            {
                if (phonebook.ContainsKey(name))
                {
                    Console.WriteLine(name + "=" + phonebook[name]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
