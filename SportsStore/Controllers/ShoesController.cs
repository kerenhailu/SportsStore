using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsStore.Controllers
{
    public class ShoesController : Controller
    {
        StoreDbContextDataContext dbContext = new StoreDbContextDataContext();
        // GET: Shoes
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CardShoes()
        {
            List<Shoe> listShoes = dbContext.Shoes.ToList();
            return View(listShoes);
        }
        public ActionResult TableShoes()
        {
            List<Shoe> listShoes = dbContext.Shoes.ToList();
            return View(listShoes);
        }
        public ActionResult SaleShoes()
        {
            List<Shoe> listShoes = dbContext.Shoes.ToList();
            List<Shoe> SaleShoes = listShoes.Where(item => item.IsSale == true).ToList();
            return View(SaleShoes);
        }
        public ActionResult SortShoes()
        {
            List<Shoe> listShoes = dbContext.Shoes.ToList();
            List<Shoe> ListShoesSort = listShoes.OrderBy(item => item.Price).ToList();
            return View(ListShoesSort);
        }
    }
}
