using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimal
{
    class StringAssignment_3
    {
        static void Main()
        {
            string first, second;
            Console.WriteLine("Enter the first string : ");
            first = Console.ReadLine();

            Console.WriteLine("Enter the second string : ");
            second = Console.ReadLine();

            int option = 0;
            string str;
            str = String.Concat(first, second);

            Console.WriteLine("Enter The Below options to perform different string opertion -");
            Console.WriteLine("1. Concatente two string");
            Console.WriteLine("2. Find the length of string");
            Console.WriteLine("3. Substring");
            Console.WriteLine("4. Replace");
            Console.WriteLine("5. Upper Case");
            Console.WriteLine("6. Lower Case");
            Console.WriteLine("7. Trim");
            Console.WriteLine("8. Split");
            Console.WriteLine("9. Enter 9 to exit from loop!");

            while (option!=9)
            {
                option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                    {
                    case 1: 
                        Console.WriteLine("Concatenated String  : {0}",str);
                        break;

                    case 2:
                        Console.WriteLine("Length of string : {0} + {1} = {2}",first.Length,second.Length,str.Length);
                        break;

                    case 3:
                        Console.WriteLine("substring occurs within a given string : {0}",first.Contains(second));
                        break;

                    case 4: string old, New;
                        Console.WriteLine("Enter the old value(Which you want to be replaced) :");
                        old = Console.ReadLine();
                        Console.WriteLine("Enter the new value :");
                        New = Console.ReadLine();
                        string newValue = str.Replace(old, New);
                        Console.WriteLine("New string : {0}",newValue);
                        break;

                    case 5:
                        Console.WriteLine("Conveted in Upper case : {0}",str.ToUpper());
                        break;

                    case 6:
                        Console.WriteLine("Conveted in lower case : {0}", str.ToLower());
                        break;

                    case 7:
                        string trim = str.Trim();
                        Console.WriteLine("Trimed String(By default trailing spaces will be removed) : {0}", trim);
                        break;

                    case 8:
                        Console.WriteLine("Enter the Seperater value : ");
                       // char[] sep = Convert.ToChar(Console.ReadLine());
                       // char[] seps = str.Split(sep,0);

                        Console.WriteLine("Splited Value : {0}", seps);
                        break;


                    default:
                        Console.WriteLine("Invlid Number Entered - Terminited!!");
                        option = 9;
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
