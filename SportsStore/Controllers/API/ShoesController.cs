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
    public class ShoesController : ApiController
    {
        StoreDbContextDataContext dbContext = new StoreDbContextDataContext();

        // GET: api/Shoes
        public IHttpActionResult Get()
        {
            try { 
            List<Shoe>ListShoes= dbContext.Shoes.ToList();
            return Ok(new {ListShoes});
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

        // GET: api/Shoes/5
        public IHttpActionResult Get(int id)
        {
            try { 
            Shoe shoes = dbContext.Shoes.First(item => item.Id == id);
            return Ok(new { shoes });
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

        // POST: api/Shoes
        public IHttpActionResult Post([FromBody]Shoe shoes)
        {
            try { 
            dbContext.Shoes.InsertOnSubmit(shoes);
            dbContext.SubmitChanges();
            List<Shoe> ListShoes = dbContext.Shoes.ToList();
            return Ok(new { ListShoes });
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

        // PUT: api/Shoes/5
        public IHttpActionResult Put(int id, [FromBody]Shoe shoes)
        {
            try { 
            Shoe shoesToChange = dbContext.Shoes.First(item => item.Id == id);
            shoesToChange.Img = shoes.Img;
            shoesToChange.IsSale=shoes.IsSale;
            shoesToChange.Amount = shoes.Amount;
            shoesToChange.Company=shoes.Company;
            shoesToChange.Price = shoes.Price;
            shoesToChange.ShoeType = shoes.ShoeType;
            shoesToChange.Model = shoes.Model;
            dbContext.SubmitChanges();
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

        // DELETE: api/Shoes/5
        public IHttpActionResult Delete(int id)
        {
            try { 
            Shoe shoesToDelete = dbContext.Shoes.First(item => item.Id == id);
            dbContext.Shoes.DeleteOnSubmit(shoesToDelete);
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
