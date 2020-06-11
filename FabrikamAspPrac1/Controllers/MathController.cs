using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FabrikamAspPrac1.Controllers
{
    public class MathController : Controller
    {
        // GET: Math
        public ActionResult LoanRateCalculator()
        {
            return View();
        }
    }
}