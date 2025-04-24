using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBX.Builder.App.Models
{
    public class Bits
    {
        public string Name { get; set; }
        public string Acronym { get; set; }
        public BitStats Stats { get; set; }
    }

    public class BitStats
    {
        public double Weight { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Stamina { get; set; }
        public int Dash { get; set; }
        public int Resistance { get; set; }
    }

}
