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

        public ActionResult ShirtTable()
        {
            List<Clothing> ListShirt = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            return View(ListShirt);
        }
        public ActionResult ShirtCard()
        {
            List<Clothing> ListShirt = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            
            return View(ListShirt);
        }
        public ActionResult LongShirt()
        {
            List<Clothing> ListShirt = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            List<Clothing> ListLongShirt = ListShirt.Where(item => item.IsShort ==false ).ToList();
            return View(ListLongShirt);
        }
        
        public ActionResult TShirt()
        {
            List<Clothing> ListShirt = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            List<Clothing> ListTShirt = ListShirt.Where(item => item.IsShort == true).ToList();
            return View(ListTShirt);
        }
        public ActionResult DreyfitShirt()
        {
            List<Clothing> ListShirt = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            List<Clothing> ListDreyfitShirt = ListShirt.Where(item => item.IsDreyfit == true).ToList();
            return View(ListDreyfitShirt);
        }
        public ActionResult SortShirt()
        {
            List<Clothing> ListShirt = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            List<Clothing> ListShirtSort =ListShirt.OrderBy(item => item.Price).ToList();
            return View(ListShirtSort);
        }
        public ActionResult FemaleShirt()
        {
            List<Clothing> ListShirt = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            List<Clothing> ListFemaleShirt = ListShirt.Where(item => item.Gender == "female").ToList();
            return View(ListFemaleShirt);
        }
        public ActionResult MaleShirt()
        {
            List<Clothing> ListShirt = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            List<Clothing> ListMaleShirt = ListShirt.Where(item => item.Gender == "male").ToList();
            return View(ListMaleShirt);
        }
       

    }
}
