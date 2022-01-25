using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsStore.Controllers
{
    public class PantsController : Controller
    {
        StoreDbContextDataContext dbContext = new StoreDbContextDataContext();
        string TypeOfTheCloth = "pants";
        // GET: Pants
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TableOfPants()
        {
            List<Clothing> ListPants = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            ViewBag.ListPants = ListPants;
            return View();
        }
        public ActionResult CardOfPants()
        {
            List<Clothing> ListPants = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            ViewBag.ListPants = ListPants;
            return View();
        }
        public ActionResult LongPants()
        {
            List<Clothing> ListPants = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            List<Clothing> ListLongPants = dbContext.Clothings.Where(item => item.IsShort == false).ToList();
            ViewBag.LongPants = ListLongPants;
            return View();
        }

        public ActionResult shortPants()
        {
            List<Clothing> ListPants = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            List<Clothing> ListshortPants = dbContext.Clothings.Where(item => item.IsShort == true).ToList();
            ViewBag.shortPants = ListshortPants;
            return View();
        }
        public ActionResult DreyfitPants()
        {
            List<Clothing> ListPants = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            List<Clothing> ListDreyfitPants = dbContext.Clothings.Where(item => item.IsDreyfit == true).ToList();
            ViewBag.DreyfitPants = ListDreyfitPants;
            return View();
        }
        public ActionResult SortPants()
        {
            List<Clothing> ListPants = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            List<Clothing> ListPantsSort = ListPants.OrderBy(item => item.Price).ToList();
            ViewBag.SortPants = ListPantsSort;
            return View();
        }
    }
}


