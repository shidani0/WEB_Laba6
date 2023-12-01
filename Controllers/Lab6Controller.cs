using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LAB6.Controllers
{
    public class Lab6Controller : Controller
    {
        // GET: Lab6
        public ActionResult Index()
        {
            List<string> tovar = GettovarList();
            return View(tovar);
        }

        public ActionResult SecondView()
        {
            return View(GettovarList().OrderBy(x => x).ToList());
        }

        public ActionResult ThirdView()
        {
            return View(GettovarList().OrderBy(x => x).ToList());
        }
        public List<string> GettovarList()
        {
            List<string> tovar = new List<string>();
            tovar.Add("Футболка");
            tovar.Add("Джинсы");
            tovar.Add("Шорты");
            tovar.Add("Носки");
            tovar.Add("Юбка");
            tovar.Add("Кепка");
            return tovar;
        }
    }

   
}