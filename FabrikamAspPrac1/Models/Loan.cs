using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Razor;

namespace FabrikamAspPrac1.Models
{
    public class Loan
    {

        public double[] months = {0, 1, 2, 3, 4};
        public double[] loanTotals = { 0, 1, 2, 3, 4 };



        public double Amount { get; set; }

        public double Percentage { get; set; }

        public void SetYears()
        {
            var monthRate = Percentage / 12;


            for(var i = 1; i < 6; i++)
            {
                months[i-1] = (Amount)
            }
        }

    }
}