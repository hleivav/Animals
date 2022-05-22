using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Bird : Animal
    {
        public int NoofFeathers { get; set; }
        public Bird(string name, double weight, int age, int noOfLegs, bool tail, int noOfFeathers) : base(name, weight, age, noOfLegs, tail)
        {
            NoofFeathers = noOfFeathers;    
        }

        public override string DoSound()
        {
            return "Pip"; 
        }
        public override string Stats()
        {
            return base.Stats() + $", Antal fjädrar: {NoofFeathers}"; 
        }
    }
}
