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
            return View(listSportsEquipment);
        }
        public ActionResult SportsEquipmentTable()
        {
            List<SportsEquipment> listSportsEquipment = dbContext.SportsEquipments.ToList();
            return View(listSportsEquipment);
        }
        public ActionResult EquipmentFootball()
        {
            List<SportsEquipment> listSportsEquipment = dbContext.SportsEquipments.ToList();
            List<SportsEquipment> listEquipmentFootball = listSportsEquipment.Where(item => item.sportType == "football").ToList();
            return View(listEquipmentFootball);
        }
        public ActionResult EquipmentBasketball()
        {
            List<SportsEquipment> listSportsEquipment = dbContext.SportsEquipments.ToList();
            List<SportsEquipment> EquipmentBasketball = listSportsEquipment.Where(item => item.sportType == "basketball").ToList();
            return View(EquipmentBasketball);
        }
        public ActionResult EquipmentSort()
        {
            List<SportsEquipment> listSportsEquipment = dbContext.SportsEquipments.ToList();
            List<SportsEquipment> ListSportsEquipmentSort = listSportsEquipment.OrderBy(item => item.Price).ToList();
            return View(ListSportsEquipmentSort);
        }
    }
}