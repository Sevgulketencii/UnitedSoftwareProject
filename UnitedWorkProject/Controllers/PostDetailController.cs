using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
            var response = await client.GetAsync("https://localhost:44308/api/Post/" + id);
            if (response.IsSuccessStatusCode)
            {
                var Json = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<PostModel>(Json);
                return View(values);
            }
            return View();
        }
    }
}
