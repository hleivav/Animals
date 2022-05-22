using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Worm : Animal
    {
        public bool IsPoisonous { get; set; }
        public Worm(string name, double weight, int age, int noOfLegs, bool tail, bool isPoisonous) : base(name, weight, age, noOfLegs, tail)
        {
            IsPoisonous = isPoisonous;
        }

        public override string DoSound()
        {
            return "No sound"; 
        }
        public override string Stats()
        {
            string isP = ""; 
            if (IsPoisonous == true)
            {
                isP = "Ja"; 
            }
            else
            {
                isP = "Nej"; 
            }
            return base.Stats() + $", Är giftig: {isP}"; 
        }
    }
}
