using System;
using System.Collections.Generic;
using System.Text;

namespace Iearxiya
{
    public interface ICar
    {
        int Year { get; set; }
        int HorsePower { get; set; }

        void Driving();

        void Seat();
    }
}
