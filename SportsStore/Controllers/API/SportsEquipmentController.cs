using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            try
            {
                List<SportsEquipment> ListsportsEquipment = dbContext.SportsEquipments.ToList();
                return Ok(new { ListsportsEquipment });
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/SportsEquipment/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                SportsEquipment sportsEquipment = dbContext.SportsEquipments.First(item => item.Id == id);
                return Ok(new { sportsEquipment });
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        // POST: api/SportsEquipment
        public IHttpActionResult Post([FromBody] SportsEquipment Equipment)
        {
            try { 
            dbContext.SportsEquipments.InsertOnSubmit(Equipment);
            dbContext.SubmitChanges();
            List<SportsEquipment> ListsportsEquipment = dbContext.SportsEquipments.ToList();
            return Ok(new { ListsportsEquipment });
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/SportsEquipment/5
        public IHttpActionResult Put(int id, [FromBody]SportsEquipment Equipment)
        {
            try { 
            SportsEquipment sportsEquipmentToUpdate = dbContext.SportsEquipments.First(item => item.Id == id);
            sportsEquipmentToUpdate.IdOfTheGroup = Equipment.IdOfTheGroup;
            sportsEquipmentToUpdate.Amount=Equipment.Amount;
            sportsEquipmentToUpdate.sportType=Equipment.sportType;
            sportsEquipmentToUpdate.Price=Equipment.Price;
            sportsEquipmentToUpdate.Img=Equipment.Img;
            sportsEquipmentToUpdate.Company=Equipment.Company;
            sportsEquipmentToUpdate.ProductName=Equipment.ProductName;
            dbContext.SubmitChanges();
            return Ok("you Update the ");
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/SportsEquipment/5
        public IHttpActionResult Delete(int id)
        {
            try { 
            SportsEquipment sportsEquipmentToDelete = dbContext.SportsEquipments.First(item => item.Id == id);
            dbContext.SportsEquipments.DeleteOnSubmit(sportsEquipmentToDelete);
            dbContext.SubmitChanges();
            return Ok("you delete the Equipment");
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
