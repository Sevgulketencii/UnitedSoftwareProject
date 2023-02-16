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
    public class PostController : ControllerBase
    {
        Dbcontext baglan = new Dbcontext();

        [HttpGet]
        public IActionResult List()
        {
            var list = baglan.PostDbSet.ToList();
            return Ok(list);
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var remove = baglan.PostDbSet.Find(id);
            if (remove != null)
            {
                baglan.Remove(remove);
                baglan.SaveChanges();
                return Ok();
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Add(Post p)
        {
            baglan.PostDbSet.Add(p);
            baglan.SaveChanges();
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var veri = baglan.PostDbSet.Find(id);
            if (veri != null)
            {
                return Ok(veri);
            }
            return NotFound();
        }

        [HttpPut]
        public IActionResult Update(Post p)
        {
            var update = baglan.PostDbSet.Find(p.postId);
            if (update != null)
            {
                update.postDate = p.postDate;
                update.postDescription = p.postDescription;
                update.postImgUrl = p.postImgUrl;
                update.postStatus = p.postStatus;
                update.postTitle = p.postTitle;
                baglan.SaveChanges();
                return Ok();
            }
            return NotFound();

        }
    }
}
