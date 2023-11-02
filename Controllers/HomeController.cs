using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataPassVtoC.Models;
namespace DataPassVtoC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string PostUsingParameter(string firstName,string lastName)
        {
            return "From parameter-"+firstName +","+lastName;
        }
        [HttpPost]
        public string PostUsingRequest()
        {
            string firstName = Request["firstName"];
            string lastName = Request["lastName"];

            return "From Request-" + firstName + "," + lastName;
        }
        [HttpPost]
        public string PostUsingFormCollection(FormCollection form)
        {
            string firstName = form["firstName"];
            string lastName = form["lastName"];

            return "From Collection-" + firstName + "," + lastName;
        }
        [HttpPost]
        public string PostUsingStronglyBinding(Employee emp)
        {

            return "From StronglyBinding-" + emp.firstName + "," + emp.lastName;
        }
    }
}