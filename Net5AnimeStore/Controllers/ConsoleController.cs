using Microsoft.AspNetCore.Mvc;
using Net5AnimeStore.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net5AnimeStore.Controllers
{
    public class ConsoleController : Controller
    {
        private readonly IConsoleRepository _consoleRepository;        

        public ConsoleController(IConsoleRepository consoleRepository)
        {
            _consoleRepository = consoleRepository;
        }

        public IActionResult Index()
        {
            var result = _consoleRepository.GetAll();

            return View(result);
        }

        public IActionResult Detail(int id)
        {
            var result = _consoleRepository.GetById(id);

            return View(result);
        }

        [Route("console/create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("console/create")]
        public IActionResult Create(Models.Console model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            _consoleRepository.Save(model);

            ViewBag.Message = "Created with success!";

            return RedirectToAction("Index");
        }
    }
}
