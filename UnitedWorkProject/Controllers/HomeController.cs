using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UnitedWorkProject.Models;

namespace UnitedWorkProject.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        UserManager _user = new UserManager(new EfUserDal());
        
        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();
            var responce = await client.GetAsync("https://localhost:44308/api/Post");
            var Json = await responce.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<PostModel>>(Json);
            var klnc = User.Identity.Name;
            var usId = _user.WhoUser(klnc);
            var list = values.Where(x => x.User == usId.UserId).ToList();
            return View(list);
           
        }

        [HttpGet]
        public IActionResult PostAdd()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PostAdd(PostModel p)
        {
            var klnc = User.Identity.Name;
            var usId = _user.WhoUser(klnc);
            p.User = usId.UserId;
            p.postStatus = true;

            if (ModelState.IsValid)
            {
                HttpClient client = new HttpClient();
                var json = JsonConvert.SerializeObject(p);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var responce = await client.PostAsync("https://localhost:44308/api/Post", content);
                if (responce.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                
            }
            return View(p);
        }

        public async Task<IActionResult> PostRemove(int id)
        {
            HttpClient client = new HttpClient();
            var responce = await client.DeleteAsync("https://localhost:44308/api/Post/" + id);
            if (responce.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }



    }
}

