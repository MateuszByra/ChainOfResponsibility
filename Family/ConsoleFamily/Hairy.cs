using Family.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFamily
{
    public class Hairy : IHairy
    {
        private readonly string owner;

        public Hairy(string owner)
        {
            this.owner = owner;
        }

        public void GrowHair()
        {
            Console.WriteLine("{0}: hair gets long", this.owner);
        }
    }
}
