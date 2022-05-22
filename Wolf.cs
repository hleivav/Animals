using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Wolf : Animal
    {
        public double Height { get; set; }
        public Wolf(string name, double weight, int age, int noOfLegs, bool tail, double height) : base(name, weight, age, noOfLegs, tail)
        {
            Height = height;
        }

        public override string DoSound()
        {
            return "Aooooo"; 
        }
        public override string Stats()
        {

            return base.Stats() + $", Vargen är {Height} meter hög";
        }
    }
}
