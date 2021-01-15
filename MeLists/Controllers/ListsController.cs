using MeLists.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeLists.Controllers
{
    public class ListsController : Controller
    {
        // GET: Lists
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShoppingList()
        {
            List<ListModel> lijstje = new List<ListModel>();
            lijstje.Add(new ListModel { Item = "Banaan", Quantity = 4, Measure = "Pcs", Check = false });
            lijstje.Add(new ListModel { Item = "Melk", Quantity = 2, Measure ="Litres", Check = false });
            lijstje.Add(new ListModel { Item = "Brood", Quantity = 1, Measure = "Loaf", Check = false });

            return View(lijstje);

        }
    }
}