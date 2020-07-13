using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_5RealityShowInheritanceComposition
{
    public class DreamHouseHunterApplication : ContestantApplication 
    {
        private string JobTitle { get; set; }
        private double CurrentAnnualIncome { get; set; }
        private DateTime DateBuyingHouse { get; set; }
        private int NumberofBedrooms { get; set; }
        private int NumberofBathrooms { get; set; }

        public DreamHouseHunterApplication(string JobTitle, double CurrentAnnualIncome, DateTime DateBuyingHouse, int NumberofBedrooms, int NumberofBathrooms)
        {
            
            this.JobTitle = JobTitle;
            this.CurrentAnnualIncome = CurrentAnnualIncome;
            this.DateBuyingHouse = DateBuyingHouse;
            this.NumberofBedrooms = NumberofBedrooms;
            this.NumberofBathrooms = NumberofBathrooms;

        }

        public override void Accept()
        {

            Console.WriteLine($"{FirstName} {LastName}, You've been accepted to 'Dream House Hunters'.");

        }

    }
}
