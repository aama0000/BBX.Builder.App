using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBX.Builder.App.Models
{
    public class Blade
    {
        public string Name { get; set; }
        public BladeStats Stats { get; set; }
    }

    public class BladeStats
    {
        public bool CX { get; set; }
        public double Weight { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Stamina { get; set; }
    }

}
