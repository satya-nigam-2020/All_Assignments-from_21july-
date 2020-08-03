using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimal
{
    interface IVolume
    {
        // readonly double len=2;
        //readonly double breath=4;

        double Volume
        {
            get;
        }

    }

    interface IArea
    {
        double SurfaceArea();
    }

    interface ISolid : IArea, IVolume
    {

    }
    public abstract class Solid : ISolid
    {
        public double radius;
        public const double pi = 3.14;

        public Solid(double radius)
        {
            Radius = radius;
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        //public abstract double Pi
        //{
        //    get;
        //}

        public abstract double Volume
        {
            get;
        }

        abstract public double SurfaceArea();
    }

    public class Cylinder : Solid
    {
        double height;

        double Surface_Area;

        public Cylinder(double height, double radius) : base(radius)
        {
            Console.WriteLine("{0} and {1}", height, radius);
            Height = height;
        }

        //public override double Volume
        //{
        //    get { return Volume; }
        //}

       

        // Surface_Area = 2 * pi* radius * (radius + height);

        public override double SurfaceArea()
        {
            return 2 * pi * radius * (radius + height); ;
        }

        public override double Volume
        {
            get
            {

                Console.WriteLine("Volume of Cylinder is:");
                return pi * Radius * Radius * height;
            }
        }

       

        public double Height
           {

              get {return height;}
            set { height = value; }

           }

    }

    class Sphere : Solid
    {
        double height;
        public override double SurfaceArea()
        {



            Console.WriteLine("Area of Sphere is:");
            return (4 / 3) * pi * Radius * Radius * Radius;
        }



        public override double Volume
        {
            get
            {
               
                Console.WriteLine("Volume of Sphere is:");
                return 4 * pi * Radius * Radius;
            }
        }



        public Sphere(double height, double radius) : base(radius)
        {
            Console.WriteLine("{0} and {1}", height, radius);
        }

        //public double Height
        //{
        //    get { return height; }
        //    set { height = value; }
        //}
    }

    class Assignment2
    {
        static void Main()
        {
            Cylinder obj = new Cylinder(42,7);
            Sphere obj1 = new Sphere(9, 8);
            Console.WriteLine("------------------------------------RESULT-------------------------------------");
            Console.WriteLine(obj.SurfaceArea());
            Console.WriteLine("------------------------------------RESULT------------------------------------ -");
            Console.WriteLine(obj.Volume);
            Console.WriteLine("------------------------------------RESULT------------------------------------ -");



            Console.WriteLine(obj1.SurfaceArea());
            Console.WriteLine("------------------------------------RESULT------------------------------------ -");
            Console.WriteLine(obj1.Volume);
        }
    }
}
