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
                IHairy hairy = member.As<IHairy>();
                if (hairy != null)
                    hairy.GrowHair();

                IBearded bearded = member.As<IBearded>();
                if (bearded != null)
                    bearded.GrowBeard();
            }

            Console.WriteLine(new string('-',20));
        }

        public void SummerComes()
        {
            Console.WriteLine("Summer is here...");
            foreach (FamilyMember member in this.members)
            {
                IEmotional emotional = member.As<IEmotional>();
                if (emotional != null)
                    emotional.BeHappy();
            }

            Console.WriteLine(new string('-', 20));
        }
    }
}
