using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ASPDemo2.Models
{
    public class Class
    {
        //Use tag helpsrs to provide custom error messages and denote required fields and ranges
        [Required(ErrorMessage = "Please enter a monthly investment amount.")]
        [Range(1, 500, ErrorMessage = "Monthly investment amount must be between 1 and 500")]
        public decimal? MonthlyInvestment { get; set; } //Make the type nullable and provide getters ans setters to allow for retrieval and edits

        [Required(ErrorMessage = "Please enter a yearly interest rate.")]
        [Range(0.1, 10, ErrorMessage = "Yearly interest rate must be between 0.1 and 10.0.")]
        public decimal? YearlyInterestRate { get; set; }

        [Required(ErrorMessage = "Please enter a number of years.")]
        [Range(1, 50, ErrorMessage = "Number of years must be between 1 and 50.")]
        public int? Years { get; set; }

        //Create a nullable function to calculate the future value of the investment
        public decimal? CalculateFutureValue()
        {
            int? months = Years * 12; //Declare a field for the months of the year
            decimal? monthlyInterestRate = YearlyInterestRate / 12 / 100; //Declare a field that will calculate the monthly interest rate
            decimal? futureValue = 0; //Dedlare a nullable future value
            //Use a for loop to iterate over the number of months and set the future value 
            for(int i = 0; i < months; i++)
            {
                futureValue = (futureValue + MonthlyInvestment) * (1 + monthlyInterestRate);
            }
            return futureValue;
        }
    }
}
