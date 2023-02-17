using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using UnitedWorkProject.Models;

namespace UnitedWorkProject.ViewComponents.PostDetail
{
    public class _FoodPost: ViewComponent
    {
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            HttpClient client = new HttpClient();
            var responce = await client.GetAsync("https://localhost:44308/api/FoodPost");
            var Json = await responce.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<FoodPostModel>>(Json);

            var list = values.Where(x => x.Postid == ViewBag.id).ToList();
            return View(list);
        }
    }
}
