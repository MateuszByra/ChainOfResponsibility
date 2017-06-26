using Family.Common;
using System;

namespace ConsoleFamily
{
    public class Dog : IEmotional
    {
        public void BeHappy()
        {
            Console.WriteLine("tail waving");
        }
    }
}
