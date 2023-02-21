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
    public class _PostDetail : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("https://localhost:44308/api/Post/" + id);

            var Json = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<PostModel>(Json);

            ViewBag.id = id;
            ViewBag.pId = id;

            return View(values);
            
        }
    }
}
