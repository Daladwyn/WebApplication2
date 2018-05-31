using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Person> personList;
            using (MyItemsDbcontext Db = new MyItemsDbcontext())
            {
                personList = Db.People.ToList();
            }
            if (personList == null)
            {
                personList = new List<Person>();
                // add in errormessage to the user that no connection to Db was established.
            }
                return View(personList);
        }

        
    }
}