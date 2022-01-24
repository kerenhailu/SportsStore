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
        public ActionResult AllTheShoes()
        {
            List<Shoe> listShoes= dbContext.Shoes.ToList();
            ViewBag.Shoes = listShoes;
            return View();
        }
        public ActionResult ShowTable()
        {
            List<Shoe> listShoes = dbContext.Shoes.ToList();
            ViewBag.Shoes = listShoes;
            return View();
        }
    }
}
