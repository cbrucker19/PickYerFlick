using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PickYerFlick.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PickYerFlick.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

    }
}
