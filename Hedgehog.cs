using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Hedgehog : Animal
    {
        public int NoOfSpikes { get; set; }
        public Hedgehog(string name, double weight, int age, int noOfLegs, bool tail, int noOfSpikes) : base(name, weight, age, noOfLegs, tail)
        {
           NoOfSpikes = noOfSpikes; 
        }

        public override string DoSound()
        {
            return "No sound"; 
        }
        public override string Stats()
        {
            return Stats() + $"Iggelkotten har {NoOfSpikes} taggar"; 
        }
    }
}
