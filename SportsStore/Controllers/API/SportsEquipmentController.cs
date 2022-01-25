using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SportsStore.Controllers.API
{
    public class SportsEquipmentController : ApiController
    {
        StoreDbContextDataContext dbContext = new StoreDbContextDataContext();
        // GET: api/SportsEquipment
        public IHttpActionResult Get()
        {
            List<SportsEquipment> ListsportsEquipment=dbContext.SportsEquipments.ToList();
            return Ok(new { ListsportsEquipment });
        }

        // GET: api/SportsEquipment/5
        public IHttpActionResult Get(int id)
        {
            SportsEquipment sportsEquipment = dbContext.SportsEquipments.First(item => item.Id == id);
            return Ok(new {sportsEquipment});
        }

        // POST: api/SportsEquipment
        public IHttpActionResult Post([FromBody] SportsEquipment Equipment)
        {
            dbContext.SportsEquipments.InsertOnSubmit(Equipment);
            dbContext.SubmitChanges();
            List<SportsEquipment> ListsportsEquipment = dbContext.SportsEquipments.ToList();
            return Ok(new { ListsportsEquipment });
        }

        // PUT: api/SportsEquipment/5
        public IHttpActionResult Put(int id, [FromBody]SportsEquipment Equipment)
        {
            SportsEquipment sportsEquipmentToUpdate = dbContext.SportsEquipments.First(item => item.Id == id);
            sportsEquipmentToUpdate.IdOfTheGroup = Equipment.IdOfTheGroup;
            sportsEquipmentToUpdate.Amount=Equipment.Amount;
            sportsEquipmentToUpdate.sportType=Equipment.sportType;
            sportsEquipmentToUpdate.Price=Equipment.Price;
            sportsEquipmentToUpdate.Img=Equipment.Img;
            sportsEquipmentToUpdate.Company=Equipment.Company;
            sportsEquipmentToUpdate.ProductName=Equipment.ProductName;
            dbContext.SubmitChanges();
            return Ok("you Update the Equipment");
        }

        // DELETE: api/SportsEquipment/5
        public IHttpActionResult Delete(int id)
        {
            SportsEquipment sportsEquipmentToDelete = dbContext.SportsEquipments.First(item => item.Id == id);
            dbContext.SportsEquipments.DeleteOnSubmit(sportsEquipmentToDelete);
            dbContext.SubmitChanges();
            return Ok("you delete the Equipment");
        }
    }
}
