using Microsoft.AspNetCore.Mvc;
using Net5AnimeStore.Models;
using Net5AnimeStore.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net5AnimeStore.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameRepository _gameRepository;

        public GameController(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public IActionResult Index()
        {
            var result = _gameRepository.GetAll();

            return View(result);
        }

        public IActionResult Detail(int id)
        {
            var result = _gameRepository.GetById(id);

            return View(result);
        }

        [Route("game/create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("game/create")]
        public IActionResult Create(Game model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            _gameRepository.Save(model);

            ViewBag.Message = "Created with success!";

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var result = _gameRepository.GetById(id);

            return View(result);
        }

        [HttpPost]
        [Route("game/edit")]
        public IActionResult Edit(Game model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            _gameRepository.Update(model);

            ViewBag.Message = "Modified with success!";

            return RedirectToAction("Index");
        }

        public IActionResult Remove(int id)
        {
            var result = _gameRepository.GetById(id);
            _gameRepository.Delete(result);

            return RedirectToAction("Index");
        }
    }
}
