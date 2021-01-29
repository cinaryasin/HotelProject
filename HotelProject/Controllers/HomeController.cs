using HotelEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelProject.Controllers
{
    public class HomeController : Controller
    {
        Model1 context = new Model1();
        public ActionResult Index()
        {

            Customer customer = new Customer
            {
                FirsName = "Yasin",
                LastName = "İbrahim",
                E_mail = "asdasdasdas",
                TcNo = "12121312332132"
            };
            HotelBusiness.GenericManager<Customer> manager = new HotelBusiness.GenericManager<Customer>();
            manager.Insert(customer);

            manager.Save();



            
            //    var customerManager = new HotelBusiness.ConCrete.CustomerManager();
            //    var personelManager = new HotelBusiness.ConCrete.PersonelManager();
            //    bool result = customerManager.Insert(new HotelEntities.Customer { FirsName = "YDenem", LastName = "Çınar", E_mail = "aaa", TcNo = "12132132" });
            //    bool result2 = personelManager.Insert(new HotelEntities.Personel {  FirsName = "Umut", LastName = "Sefa", Salary = null, Adress = "Gonya" });
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}