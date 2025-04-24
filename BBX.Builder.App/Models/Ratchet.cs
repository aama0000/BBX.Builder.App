using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBX.Builder.App.Models
{
    public class Ratchet
    {
        public string Name { get; set; }
        public RatchetStats Stats { get; set; }
    }

    public class RatchetStats
    {
        public double Weight { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Stamina { get; set; }
        public int Height { get; set; }
    }

}
