using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PostApi.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodPostController : ControllerBase
    {

        Dbcontext baglan = new Dbcontext();

        [HttpGet]
        public IActionResult List()
        {
            var list = baglan.FoodPostDbSet.ToList();

            return Ok(list);
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var remove = baglan.FoodPostDbSet.Find(id);
            if (remove != null)
            {
                baglan.Remove(remove);
                baglan.SaveChanges();
                return Ok();
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Add(FoodPost p)
        {
            baglan.FoodPostDbSet.Add(p);
            baglan.SaveChanges();
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var veri = baglan.FoodPostDbSet.Find(id);
            if (veri != null)
            {
                return Ok(veri);
            }
            return NotFound();
        }

        [HttpPut]
        public IActionResult Update(FoodPost p)
        {
            var update = baglan.FoodPostDbSet.Find(p.FoodPostId);
            if (update != null)
            {
                update.FoodPostTitle = p.FoodPostTitle;
                update.FPostDescription = p.FPostDescription;
                
                baglan.SaveChanges();
                return Ok();
            }
            return NotFound();

        }


    }
}
