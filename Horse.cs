using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Horse : Animal
    {
        public int Jumps { get; set; }
        public Horse(string name, double weight, int age, int noOfLegs, bool tail, int jumps) : base(name, weight, age, noOfLegs, tail)
        {
            Jumps = jumps;
        }
        public override string DoSound()
        {
            return "Wheheheheeee";
        }
        public override string Stats()
        {
            return base.Stats() + $", Hoppar: {Jumps} meter.";
        }
    }
}