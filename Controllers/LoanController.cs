using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sheet2.Controllers
{
    public class LoanController : Controller
    {
        // GET: Loan
        [HttpGet]
        public ActionResult Loan()
        {
            return View();
        }
        [HttpPost]
        
        public ActionResult Loan(float years, float amount, float rate)
        {
            try
            {
                ViewBag.Years = years;
                ViewBag.Amount = amount;
                ViewBag.Rate = rate;
                if (ViewBag.Years != null && ViewBag.Amount != null && ViewBag.Rate != null)
                {
                    float total = 0;

                    for (int i = 0; i < years; i++)
                    {
                        total += amount * rate / 100;
                    }
                    total += amount;
                    ViewBag.Total = total;
                }

                return View();
            }
            catch (Exception e) {
                String message = "Error";
                ViewBag.Message = message;
                return View();
            }
        }
    }
}