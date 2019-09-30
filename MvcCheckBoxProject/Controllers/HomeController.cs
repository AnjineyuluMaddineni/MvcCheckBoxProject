using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCheckBoxProject.ViewModel;
using System.Text;

namespace MvcCheckBoxProject.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            List<Fruits> fr = new List<Fruits>();
            fr.Add(new Fruits() { fruitId = 1, fruitName = "Apple", isCheck = false });
            fr.Add(new Fruits() { fruitId = 2, fruitName = "Mango", isCheck = false });
            fr.Add(new Fruits() { fruitId = 3, fruitName = "Sapoto", isCheck = false });
            fr.Add(new Fruits() { fruitId = 4, fruitName = "orange", isCheck = false });
            fr.Add(new Fruits() { fruitId = 5, fruitName = "Grapes", isCheck = false });
            FruitList frlist = new FruitList();
            frlist.fruits = fr;
            return View(frlist);
        }
        [HttpPost]
        public ActionResult Index(FruitList fr)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in fr.fruits)
            {
                if (item.isCheck)
                {
                    sb.Append(item.fruitName + ",");
                }
            }
            ViewBag.selectFruit = "selected fruits are "+sb.ToString();
            return View(fr);
        }
    }
}