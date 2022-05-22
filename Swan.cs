using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals 
{
    internal class Swan : Bird
    {
        public double NeckLenght { get; set; }
        public Swan(string name, double weight, int age, int noOfLegs, bool tail, int noOfFeathers, double neckLenght) : base(name, weight, age, noOfLegs, tail, noOfFeathers)
        {
            NeckLenght = neckLenght;    
        }
        public override string DoSound()
        {
            return "Swan sound"; 
        }

    }
}
