using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net5AnimeStore.Controllers
{
    public class ConsoleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
