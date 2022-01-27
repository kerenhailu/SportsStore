using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsStore.Controllers
{
    public class ShirtController : Controller
    {
        StoreDbContextDataContext dbContext = new StoreDbContextDataContext();
        string TypeOfTheCloth = "shirt";
        // GET: Shirt
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShirtTable()
        {
            List<Clothing> ListShirt = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            ViewBag.ListShirt = ListShirt;
            return View();
        }
        public ActionResult ShirtCard()
        {
            List<Clothing> ListShirt = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            
            return View(ListShirt);
        }
        public ActionResult LongShirt()
        {
            List<Clothing> ListShirt = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            List<Clothing> ListLongShirt = dbContext.Clothings.Where(item => item.IsShort ==false ).ToList();
            ViewBag.LongShirts = ListLongShirt;
            return View();
        }
        
        public ActionResult TShirt()
        {
            List<Clothing> ListShirt = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            List<Clothing> ListTShirt = dbContext.Clothings.Where(item => item.IsShort == true).ToList();
            ViewBag.TShirts = ListTShirt;
            return View();
        }
        public ActionResult DreyfitShirt()
        {
            List<Clothing> ListShirt = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            List<Clothing> ListDreyfitShirt = dbContext.Clothings.Where(item => item.IsDreyfit == true).ToList();
            ViewBag.DreyfitShirts = ListDreyfitShirt;
            return View();
        }
        public ActionResult SortShirt()
        {
            List<Clothing> ListShirt = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            List<Clothing> ListShirtSort =ListShirt.OrderBy(item => item.Price).ToList();
            ViewBag.ListShirtSort = ListShirtSort;
            return View();
        }

    }
}
