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

    }
}