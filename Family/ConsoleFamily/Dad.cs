using Family.Common;
using System;

namespace ConsoleFamily
{
    public class Dad : IBearded, IEmotional
    {
        public void BeHappy()
        {
            Console.WriteLine("hoho");
        }

        public void GrowBeard()
        {
            Console.WriteLine("beard grows");
        }
    }
}
