using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_5RealityShowInheritanceComposition
{
    class ParadiseIslandApplication : ContestantApplication
    {
        private string Gender { get; set; }
        private string NameofBoyfriendGirlfriend { get; set; }
        private int YearsDating { get; set; }

        public ParadiseIslandApplication(string Gender, string NameofBoyfriendGirlfriend, int YearsDating)
        {

            this.Gender = Gender;
            this.NameofBoyfriendGirlfriend = NameofBoyfriendGirlfriend;
            this.YearsDating = YearsDating;

        }

        public override void Accept()
        {

            Console.WriteLine($"{FirstName} {LastName}, You've been accepted to 'Paradise Island'.");

        }
    }
}
