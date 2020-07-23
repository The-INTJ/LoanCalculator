using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Razor;

namespace FabrikamAspPrac1.Models
{
    public class Loan
    {

        public double[] months = {0, 0, 0, 0, 0};
        public double[] loanTotals = { 0, 0, 0, 0, 0 };

        
        public double Amount { get; set; }

        public double Percentage { get; set; }

        public void SetYears()
        {
            if (Percentage < 0 || Amount <= 0)
            {

            } else {
                for(var i = 1; i < 6; i++)
                {
                    loanTotals[i - 1] = Amount + 1 + ((Amount * Percentage) * i-1);
                        months[i - 1] = loanTotals[i-1] / (i*12);
                }
            }

        }

    }
}