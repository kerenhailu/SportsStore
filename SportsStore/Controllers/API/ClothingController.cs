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
    public class ClothingController : ApiController
    {
        StoreDbContextDataContext dbContext = new StoreDbContextDataContext();
        // GET: api/Clothing
        public IHttpActionResult Get()
        {
            try { 
            List<Clothing>ListClothing= dbContext.Clothings.ToList();
            return Ok(new { ListClothing });
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

        // GET: api/Clothing/5
        public IHttpActionResult Get(int id)
        {
            try { 
            Clothing clothing = dbContext.Clothings.First(item => item.Id == id);
            return Ok(new {clothing});
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

        // POST: api/Clothing
        public IHttpActionResult Post([FromBody]Clothing clothing)
        {
            try { 
            dbContext.Clothings.InsertOnSubmit(clothing);
            dbContext.SubmitChanges();
            List<Clothing> ListClothing = dbContext.Clothings.ToList();
            return Ok(new { ListClothing });
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

        // PUT: api/Clothing/5
        public IHttpActionResult Put(int id, [FromBody] Clothing clothing)
        {
            try { 
            Clothing clothingToChange = dbContext.Clothings.First(item => item.Id == id);
            clothingToChange.ClothModel = clothing.ClothModel;
            clothingToChange.Amount = clothing.Amount;
            clothingToChange.IsDreyfit=clothing.IsDreyfit;
            clothingToChange.IsShort=clothing.IsShort;
            clothingToChange.Price=clothing.Price;
            clothingToChange.Img=clothing.Img;
            clothingToChange.Gender=clothing.Gender;
            clothingToChange.ClothType=clothing.ClothType;
            clothingToChange.Company=clothing.Company;
            dbContext.SubmitChanges();
            return Ok("you update");
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

        // DELETE: api/Clothing/5
        public IHttpActionResult Delete(int id)
        {
            try { 
            Clothing clothingToDelete = dbContext.Clothings.First(item => item.Id == id);
            dbContext.Clothings.DeleteOnSubmit(clothingToDelete);
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
