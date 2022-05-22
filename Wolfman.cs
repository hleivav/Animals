using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Wolfman : Animal, IPerson
    {
        public Wolfman(string name, double weight, int age, int noOfLegs, bool tail) : base(name, weight, age, noOfLegs, tail)
        {
        }

        public override string DoSound()
        {
            return "testar blaagrrr"; 
        }
        public string Talk()
        {
            return "BlaaaGrrr";
        }
    }
}
