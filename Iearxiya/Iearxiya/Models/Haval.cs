using System;
using System.Collections.Generic;
using System.Text;

namespace Iearxiya.Models
{
    public class Haval : ICar
    {
        internal static Haval haval;

        public int Year { get ; set ; }
        public int HorsePower { get ; set ; }

        public void Driving()
        {
            Console.WriteLine(" Can Drive ");
        }

        public void Seat()
        {
            Console.WriteLine("Have a seat");
        }
    }
}
