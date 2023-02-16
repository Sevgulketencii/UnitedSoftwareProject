using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitedWorkProject.Controllers
{
    [Authorize]
    public class AboutController : Controller
    {
        AboutManager about = new AboutManager(new EfAboutDal());

        public IActionResult About()
        {
            var veri = about.Status();
            return View(veri);
        }
    }
}
