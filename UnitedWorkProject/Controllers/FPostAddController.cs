using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UnitedWorkProject.Models;

namespace UnitedWorkProject.Controllers
{
    public class FPostAddController : Controller
    {
        
        public IActionResult Index(int id)
        {
            
            ViewBag.pid = id;
            return View();
        }



        public async Task<IActionResult> FPostAdd(FoodPostModel p)
        {
            
            p.FPostStatus = true;
            if (ModelState.IsValid)
            {
                HttpClient client = new HttpClient();
                var json = JsonConvert.SerializeObject(p);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var responce = await client.PostAsync("https://localhost:44308/api/FoodPost", content);
                if (responce.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "Home");
                }

            }
            return View(p);
        }
    }
}
