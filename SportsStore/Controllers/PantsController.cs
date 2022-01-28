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
            return View(ListPants);
        }
        public ActionResult CardOfPants()
        {
            List<Clothing> ListPants = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            return View(ListPants);
        }
        public ActionResult LongPants()
        {
            List<Clothing> ListPants = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            List<Clothing> ListLongPants = ListPants.Where(item => item.IsShort == false).ToList();
            return View(ListLongPants);
        }

        public ActionResult shortPants()
        {
            List<Clothing> ListPants = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            List<Clothing> ListshortPants = ListPants.Where(item => item.IsShort == true).ToList();
            return View(ListshortPants);
        }
        public ActionResult DreyfitPants()
        {
            List<Clothing> ListPants = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            List<Clothing> ListDreyfitPants = ListPants.Where(item => item.IsDreyfit == true).ToList();
            return View(ListDreyfitPants);
        }
        public ActionResult SortPants()
        {
            List<Clothing> ListPants = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            List<Clothing> ListPantsSort = ListPants.OrderBy(item => item.Price).ToList();
            ViewBag.SortPants = ListPantsSort;
            return View(ListPantsSort);
        }
        public ActionResult FemalePants()
        {
            List<Clothing> ListPants = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            List<Clothing> ListFemalePants = ListPants.Where(item => item.Gender == "female").ToList();
            return View(ListFemalePants);
        }
        public ActionResult MalePants()
        {
            List<Clothing> ListPants = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            List<Clothing> ListMalePants = ListPants.Where(item => item.Gender == "male").ToList();
            return View(ListMalePants);
        }
    }
}


