using mvcExp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcExp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //Index is action result 
        public ActionResult Index()
        {

            return View();
        }

        //Get:About
        public ActionResult About()
        {
            //I will send new information from model to the view , i need object 
            Person me = new Person(35,"Ulf Bengtsson");// sending just object to view then we can use all property there
            return View(me);//to send it down to the view 
        }

        //Get: people
        public ActionResult People()
        {
            //we add new informations
            Person.People = new List<Person>();// i need id for displaying  list  
            Person.People.Add(new Person(40,"Fridrik"));
            Person.People.Add(new Person(40, "Ali"));
            Person.People.Add(new Person(40, "Irma"));

            return View();
        }
    }
}