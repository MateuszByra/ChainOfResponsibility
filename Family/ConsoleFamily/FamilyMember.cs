using Family.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFamily
{
    public class FamilyMember
    {
        private readonly ChainElement components;

        public FamilyMember(ChainElement components)
        {
            this.components = components;
        }

        public T As<T>(T defaultValue) where T : class
        {
            return this.components.As<T>(defaultValue);
        }
    }
}
