using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Pelican : Bird
    {
        public double BeakLenght { get; set; }
        public Pelican(string name, double weight, int age, int noOfLegs, bool tail, int noOfFeathers, double beakLength) : base(name, weight, age, noOfLegs, tail, noOfFeathers)
        {
            BeakLenght = beakLength;
        }

    }

}
