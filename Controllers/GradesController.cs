using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sheet2.Controllers
{
    public class GradesController : Controller
    {
        // GET: Grade
        [HttpGet]
        public ActionResult Grades()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Grades(float t1, float t2, float t3)
        {

            ViewBag.T1 = t1;
            ViewBag.T2 = t2;
            ViewBag.T3 = t3;
            if (ViewBag.T1 != null && ViewBag.T2 != null && ViewBag.T3 != null)
            {
                float average = 0;
                average = (t1 + t2 + t3) / 3;
                Char letter = 'F';
                if (average >= 90) { letter = 'A'; }
                else if (average >= 80) { letter = 'B'; }
                else if (average >= 70) { letter = 'C'; }
                else if (average >= 60) { letter = 'D'; }

                ViewBag.Letter = letter;
                ViewBag.Average = average;
            }

            return View();

        }
    }
}