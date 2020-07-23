using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FabrikamAspPrac1.Models;

namespace FabrikamAspPrac1.Controllers
{
    public class LoanController : Controller
    {
        // GET: Loan
        public ActionResult LoanRateCalculator()
        {
            var loan = new Loan();
            return View(loan);
        }

        [HttpPost]
        public ActionResult Calculate(Loan loan)
        {

            loan.SetYears();
            return View("LoanRateCalculator", loan);
        }

        public ActionResult Clear(Loan loan)
        {
            loan.Amount = 0;
            loan.Percentage = 0;
            for (var i = 0; i < 5; i++)
            {
                loan.months[i] = 0;
                loan.loanTotals[i] = 0;
            }
            return View("LoanRateCalculator", loan);
        }

    }
}