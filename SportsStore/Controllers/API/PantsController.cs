using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SportsStore.Controllers.API
{
    public class PantsController : ApiController
    {
        StoreDbContextDataContext dbContext = new StoreDbContextDataContext();
        string TypeOfTheCloth = "pants";
        // GET: api/Pants
        public IHttpActionResult Get()
        {
            List<Clothing> ListPants = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            return Ok(new { ListPants });
        }

        // GET: api/Pants/5
        public IHttpActionResult Get(int id)
        {
            List<Clothing> ListPants = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            Clothing pants = ListPants.Find(item => item.Id == id);
            return Ok(new { pants });
        }

        // POST: api/Pants
        public IHttpActionResult Post([FromBody] Clothing pants)
        {
            dbContext.Clothings.InsertOnSubmit(pants);
            dbContext.SubmitChanges();
            return Ok("you add one more");
        }

        // PUT: api/Pants/5
        public IHttpActionResult Put(int id, [FromBody]Clothing pants)
        {
            List<Clothing> ListPants = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            Clothing pantsToChange = ListPants.Find(item => item.Id == id);
            pantsToChange.ClothModel = pants.ClothModel;
            pantsToChange.IsShort = pants.IsShort;
            pantsToChange.Amount = pants.Amount;
            pantsToChange.IsDreyfit = pants.IsDreyfit;
            pantsToChange.Gender = pants.Gender;
            pantsToChange.Price = pants.Price;
            pantsToChange.Img = pants.Img;
            pantsToChange.Company = pants.Company;
            dbContext.SubmitChanges();
            //pantsToChange.ClothType = pantsToChange.ClothType;
            return Ok("you upDate");
        }

        // DELETE: api/Pants/5
        public IHttpActionResult Delete(int id)
        {
            List<Clothing> ListPants = dbContext.Clothings.Where(item => item.ClothType == TypeOfTheCloth).ToList();
            Clothing pantsToDelete = ListPants.Find(item => item.Id == id);
            dbContext.Clothings.DeleteOnSubmit(pantsToDelete);
            dbContext.SubmitChanges();
            return Ok("you delete");
        }
    }
}
