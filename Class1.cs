using System;
using System.Collections.Generic;
using System.Text;

namespace day5
{
    class vehicle 
    {
        int gasoline;
        public void Drive()
        {
           
            if (gasoline >0)
            {
                Console.WriteLine("Car is driving");
            }


        }
          public void fuel()
          {
            if (gasoline>0)
            {
                gasoline++;
                Console.WriteLine ("fuel is present");
            }

          }
    }
    class Car:vehicle
    {
        public static void Main()
        {
            Car car = new Car();
            vehicle Vehicle = new vehicle();
            Vehicle.Drive();
            Vehicle.fuel();
            Console.Write("enter amount og gasoline");
            int gasoline = Convert.ToInt32(Console.ReadLine());
            
            Console.ReadLine();

        }
    }
}
