using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2_MVC_Grid_Copy_Paste.Controllers
{
    public class HomeController : Controller
    {
        public static List<Orders> OrdersList = new List<Orders>();
        public ActionResult Index()
        {
            OrdersList = new List<Orders>() {
                new Orders() { OrderID = 10248, CustomerName = "VINET", ShipCountry = "Rio", Freight = 32.48, OrderDate = DateTime.Now },
                new Orders() { OrderID = 10249, CustomerName = "HANAR", ShipCountry = "Alaska", Freight = 2.8, OrderDate = DateTime.Now }
            };
            ViewBag.dataSource = OrdersList;
            return View();
        }
        [HttpPost]
        public ActionResult OnPaste(PostData data, string action)
        {
            OrdersList.AddRange(data.pastedData);
            return Json(OrdersList);
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
    public class Orders
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public string ShipCountry { get; set; }
        public double Freight { get; set; }
        public DateTime OrderDate { get; set; }
    }

    public class PostData
    {
        public List<Orders> pastedData { get; set; }
    }
}