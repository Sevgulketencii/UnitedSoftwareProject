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

    }
}

