using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5._1
{
    class Computer
    {
        public int Cores { get; set; }
        public double Frequency { get; set; }
        public int Memory { get; set; }
        public int Hdd { get; set; }

        public override string ToString()
        {
            return $"{Cores} cores, {Frequency} Mhz, {Memory} GB, {Hdd} GB";
        }
    }
}
