using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_Assignment_07_30_2020_
{
    abstract class Quadrilateral
    {
       //public int Length;
        abstract public int Area(int Length);
    }
    class Sqaure : Quadrilateral
    {
        public override int Area(int Length)
        {
            return Length * Length;
        }
    }
    class Rectangle : Quadrilateral
    {
        int Breath;
        public Rectangle(int _breath)
        {
            Breath = _breath;
        }

        public override int Area(int Length)
        {
            return Breath * Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sqaure s = new Sqaure();
            Console.WriteLine(s.Area(5));

            Rectangle r = new Rectangle(6);
            Console.WriteLine(r.Area(4));

            Console.ReadLine();
        }
    }
}
