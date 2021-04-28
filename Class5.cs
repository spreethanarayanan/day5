using System;
using System.Collections.Generic;
using System.Text;

namespace day5
{
    class Class5
    {
        public static void Main()
        {
            //DateTime dt = new DateTime(2021, 5, 28, 3, 25, 5);
            //Console.WriteLine(string.Format("{0:ddd,MMM d,yyyy}"), dt);
            DateTime dt = DateTime.Now;
            Console.WriteLine(String.Format("{0:MMMM}" , dt));
            Console.ReadLine();


        }
    }
}
