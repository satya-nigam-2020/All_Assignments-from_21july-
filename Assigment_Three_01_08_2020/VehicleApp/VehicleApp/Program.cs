using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample;

namespace VehicleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Vehicle("Ferari","White",0,4,0);
            car.Display();
            car.start();
            car.stop();
            //Vehicle truck=new Vehicle("Do Not KNow",")

            Console.ReadLine();
        }


    }
}
