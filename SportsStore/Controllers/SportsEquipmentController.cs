using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsStore.Controllers
{
    public class SportsEquipmentController : Controller
    {
        StoreDbContextDataContext dbContext = new StoreDbContextDataContext();
        string g = "football";
        // GET: SportsEquipment
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SportsEquipmentCard()
        {
            List<SportsEquipment> listSportsEquipment = dbContext.SportsEquipments.ToList();
            ViewBag.SportsEquipment = listSportsEquipment;
            return View();
        }
        public ActionResult SportsEquipmentTable()
        {
            List<SportsEquipment> listSportsEquipment = dbContext.SportsEquipments.ToList();
            ViewBag.SportsEquipment = listSportsEquipment;
            return View();
        }
        public ActionResult EquipmentFootball()
        {
            List<SportsEquipment> listSportsEquipment = dbContext.SportsEquipments.ToList();
            List<SportsEquipment> listEquipmentFootball = dbContext.SportsEquipments.Where(item => item.sportType =="Football").ToList();
            ViewBag.Football = listEquipmentFootball;
            return View();
        }
        public ActionResult EquipmentBasketball()
        {
            List<SportsEquipment> listSportsEquipment = dbContext.SportsEquipments.ToList();
            List<SportsEquipment> EquipmentBasketball = dbContext.SportsEquipments.Where(item => item.sportType == "basketball").ToList();
            ViewBag.Basketball = EquipmentBasketball;
            return View();
        }
        public ActionResult EquipmentSort()
        {
            List<SportsEquipment> listSportsEquipment = dbContext.SportsEquipments.ToList();
            List<SportsEquipment> ListSportsEquipmentSort = listSportsEquipment.OrderBy(item => item.Price).ToList();
            ViewBag.EquipmentSort = ListSportsEquipmentSort;
            return View();
        }
    }
}