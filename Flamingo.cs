using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{

    internal class Flamingo : Bird
    {

        public double LegLenght { get; set; }
        public Flamingo(string name, double weight, int age, int noOfLegs, bool tail, int noOfFeathers, double legLenght) : base(name, weight, age, noOfLegs, tail, noOfFeathers)
        {
            LegLenght = legLenght; 
        }
        public override string DoSound()
        {
            return "Flamingo sound";
        }

    }

}
