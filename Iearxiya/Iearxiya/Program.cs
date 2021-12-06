using Iearxiya.Models;
using System;

namespace Iearxiya
{
    class Program
    {
        static void Main(string[] args)
        {
            Haval haval = new Haval();
            haval.Driving();
            haval.Seat();

            Bycle bycle = new Bycle();
            bycle.Driving();
            bycle.Seat();

            Bmw bmw = new Bmw();
            bmw.Driving();
            bmw.Seat();

        }
    }
}
