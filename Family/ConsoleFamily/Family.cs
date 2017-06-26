using Family.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFamily
{
    public class Family
    {
        private IEnumerable<FamilyMember> members;

        public Family(IEnumerable<FamilyMember> members)
        {
            this.members = new List<FamilyMember>(members);
        }

        public void WinterBegins()
        {
            Console.WriteLine("Winter just came...");
            foreach(FamilyMember member in this.members)
            {
                member.As<IHairy>(NullHairy.Instance).GrowHair();
                member.As<IBearded>(NullBearded.Instance).GrowBeard();
            }

            Console.WriteLine(new string('-',20));
        }

        public void SummerComes()
        {
            Console.WriteLine("Summer is here...");
            foreach (FamilyMember member in this.members)
            {
                member.As<IEmotional>(NullEmotional.Instance).BeHappy();
            }

            Console.WriteLine(new string('-', 20));
        }
    }
}
