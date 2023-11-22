using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PassDataViewtoController.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public   string PostUsingPar(string firstname,string lastname)
        {

            return "from parameter " + firstname + " " + lastname;
        }

        [HttpPost]
        public string PostUsingRequest()
        {

            string firstname = Request["firstname"];
            string lastname = Request["lastname"];


            return "from Request " + firstname + " " + lastname;



        }
    }
}