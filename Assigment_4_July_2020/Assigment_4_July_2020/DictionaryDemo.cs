using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_4_July_2020
{
    class DictionaryDemo
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> di = new Dictionary<int, string>();
            di.Add(1, "Satya Prakash");
            di.Add(2, "Sobhandip");
            di.Add(3, "Dipansh");
            di.Add(4, "Dipanjan");
            di.Add(5, "Vicky");
            Console.WriteLine("-------------Printing Dictionary Element--------------------");
            foreach(var a in di)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();

            Console.WriteLine("Count of element in dictionary : {0}",di.Count);

            Console.WriteLine("Checking index 2 in di : {0}",di.ContainsKey(2));
            Console.WriteLine("Checking Value Satya in di : {0}", di.ContainsValue("Satya Prakash"));
            Console.WriteLine("Checking index 7 in di : {0}", di.ContainsKey(7));

            Console.WriteLine("Removing All element From di : ");
            di.Clear();

            foreach(var a in di)
            {
                Console.WriteLine(a);
            }


            Console.ReadLine();

        }
    }
}
