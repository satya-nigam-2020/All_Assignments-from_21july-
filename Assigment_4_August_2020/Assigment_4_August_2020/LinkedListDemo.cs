using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_4_August_2020
{
    class LinkedListDemo
    {
        static void Main()
        {

            LinkedList<String> my_list = new LinkedList<String>();


            // Using AddLast() method 
            my_list.AddLast("Satya");
            my_list.AddLast("Dipanjan");
            my_list.AddLast("Sobhandip");
            my_list.AddLast("Tausif");
            my_list.AddLast("Girish");
            my_list.AddLast("Vicky");

            Console.WriteLine("-----------------List of Associates--------------------");

            
            // LinkedList Using foreach loop 
            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("-----------------List of Associates--------------------");

            my_list.Remove(my_list.First);

            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }


            
            Console.WriteLine("-----------------List of Associates--------------------");

            my_list.RemoveLast();

            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }

            
            my_list.Clear();
            Console.WriteLine("Number of students: {0}",
                                         my_list.Count);

            Console.ReadLine();
        }
    }
}
