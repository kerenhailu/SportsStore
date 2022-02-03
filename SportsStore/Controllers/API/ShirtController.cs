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
    public class ShirtController : ApiController
    {
        
        StoreDbContextDataContext dbContext = new StoreDbContextDataContext();
        string TypeOfTheCloth = "shirt";

        // GET: api/Shirt
        public IHttpActionResult Get()
        {
            try { 
            List<Clothing> ListShirt = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            return Ok(new { ListShirt });
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

        // GET: api/Shirt/5
        public IHttpActionResult Get(int id)
        {
            try { 
            List<Clothing> ListShirt = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            Clothing shirt = ListShirt.Find(item => item.Id == id);
            return Ok(new { shirt });
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

        // POST: api/Shirt
        public IHttpActionResult Post([FromBody] Clothing shirt)
        {
            try { 
            dbContext.Clothings.InsertOnSubmit(shirt);
            dbContext.SubmitChanges();
            return Ok("you add one more");
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

        // PUT: api/Shirt/5
        public IHttpActionResult Put(int id, [FromBody] Clothing shirt)
        {
            try { 
            List<Clothing> ListShirt = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            Clothing shirtToChange = ListShirt.Find(item => item.Id == id);
            shirtToChange.ClothModel = shirt.ClothModel;
            shirtToChange.IsShort = shirt.IsShort;
            shirtToChange.Amount = shirt.Amount;
            shirtToChange.IsDreyfit = shirt.IsDreyfit;
            shirtToChange.Gender = shirt.Gender;
            shirtToChange.Price = shirt.Price;
            shirtToChange.Img = shirtToChange.Img;
            shirtToChange.Company = shirtToChange.Company;
            dbContext.SubmitChanges();
            //shirtToChange.ClothType = shirtToChange.ClothType;
            return Ok("you upDate");
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

        // DELETE: api/Shirt/5
        public IHttpActionResult Delete(int id)
        {
            try { 
            List<Clothing> ListShirt = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            Clothing shirtToDelete = ListShirt.Find(item => item.Id == id);
            dbContext.Clothings.DeleteOnSubmit(shirtToDelete);
            dbContext.SubmitChanges();
            return Ok("you delete");
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
