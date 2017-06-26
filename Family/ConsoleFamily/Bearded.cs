using Family.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFamily
{
    public class Bearded : IBearded
    {
        private readonly string owner;

        public Bearded(string owner)
        {
            this.owner = owner;
        }

        public void GrowBeard()
        {
            Console.WriteLine("{0}: beard grows", this.owner);
        }
    }
}
