﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFamily
{
    class Program
    {
        static void Main(string[] args)
        {
            FamilyMember dad =
                new FamilyMember(
                    new object[] { new Bearded("Dad"), new Emotional("Dad", "hoho") });
            FamilyMember mom =
                new FamilyMember(
                    new object[] { new Hairy("Mom"), new Emotional("Mom", "hihi") });
            FamilyMember boy =
                new FamilyMember(
                    new object[] { new Emotional("Boy", "haha") });
            FamilyMember dog =
                new FamilyMember(
                    new object[] { new Emotional("Dog", "tail waving") });
            FamilyMember uncle =
                new FamilyMember(
                    new object[] { new Bearded("Uncle"), new Hairy("Uncle") });

            Family family =
                new Family(new FamilyMember[] { dad, mom, boy, uncle, dog });

            family.WinterBegins();
            family.SummerComes();
            Console.ReadLine();
        }
    }
}
