using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Dog : Animal
    {
        public string Breed { get; set; }
        public Dog(string name, double weight, int age, int noOfLegs, bool tail, string breed) : base(name, weight, age, noOfLegs, tail)
        {
            Breed = breed;  
        }

        public override string DoSound()
        {
            return "Woof woof";
        }
        public override string Stats()
        {
            return base.Stats() + $", Ras: {Breed}."; 
        }
        public string DogieTrick()
        {
            return $"{Name} rullar"; 
        }
    }
}
