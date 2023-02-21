using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    public class PostDetailController : Controller
    {
        
        public async Task<IActionResult> Index(int id)
        {
            HttpClient client = new HttpClient();
            var responce = await client.GetAsync("https://localhost:44308/api/FoodPost");
            var Json = await responce.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<FoodPostModel>>(Json);
            ViewBag.ıd = id;
            var list = values.Where(x => x.Postid == id ).Take(1).ToList();
            return View(list);
          
        }

        

        [HttpPost]
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
                    return RedirectToAction("Index","Home");
                }

            }
            return View(p);
        }

        public async Task<IActionResult> FPostRemove(int id)
        {
            HttpClient client = new HttpClient();
            var responce = await client.DeleteAsync("https://localhost:44308/api/FoodPost/" + id);
            if (responce.IsSuccessStatusCode)
            {
                return RedirectToAction("Index","Home");
            }
            return View();
        }

   

     
    }
}
