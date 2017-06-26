using Family.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFamily
{
    public class Emotional : ChainElement, IEmotional
    {
        private readonly string owner;
        private readonly string laughingSound;

        public Emotional(string owner, string laughingSound, ChainElement next)
        {
            this.owner = owner;
            this.laughingSound = laughingSound;
        }

        public Emotional(string owner, string laughingSound)
        {
            this.owner = owner;
            this.laughingSound = laughingSound;
        }

        public void BeHappy()
        {
            Console.WriteLine("{0}: {1}", this.owner,this.laughingSound);
        }
    }
}
