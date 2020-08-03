using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] MyArray = new string[5] { "Zebra", "Ant", "Owl", "Lion", "tiger"};
            Console.WriteLine("---------------Printing value Using for loop--------------------");
            for(var i=0;i<MyArray.Length;i++)
            {
                Console.WriteLine(MyArray[i]);
            }
            Console.WriteLine("---------------Printing value Using forEach loop--------------------");
            foreach(string s in MyArray)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("---------------Printing value Using While loop--------------------");
            int j = 0;
            while(j<5)
            {
                Console.WriteLine(MyArray[j]);
                j++;
            }
            Console.WriteLine("---------------Printing value Using Do While loop--------------------");
            j = 0;
            do
            {
               Console.WriteLine(MyArray[j]);
                j++;
            }
            while (j < 5);

            Console.WriteLine("---------------Printing value After sorting the values--------------------");
            Array.Sort(MyArray);
            for (var i = 0; i < MyArray.Length; i++)
            {
                Console.WriteLine(MyArray[i]);
            }

            string[] animals = { "Zebra", "Kiwi", "Amazona Parrot", "Tiger" };
            string[] places = { "Africa", "New Zealand", "Jamaica", "India" };

            Array.Sort(animals);
            Array.Sort(places);
            Console.WriteLine("---------------Printing animals array value Using forEach loop--------------------");

            foreach(var arr1 in animals)
            {
                Console.WriteLine(arr1);
            }

            Console.WriteLine("---------------Printing places array value Using forEach loop--------------------");

            foreach (var arr2 in places)
            {
                Console.WriteLine(arr2);
            }

            Console.ReadLine();
        }
    }
}
