using System;
using System.Collections.Generic;
using System.Text;

namespace _09__UpcastingDowncastingExplicitImplicit.Models
{
    internal class Dollar
    {
        public decimal USD { get; set; }

        public Dollar( decimal usd)
        {
            USD = usd;
        }
        public static implicit operator Dollar(Manat mant )
        {
            return new Dollar(mant.AZN / 1.7m);
        }

    }
}
