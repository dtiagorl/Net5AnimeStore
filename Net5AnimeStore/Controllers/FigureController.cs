using Microsoft.AspNetCore.Mvc;
using Net5AnimeStore.Models;
using Net5AnimeStore.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net5AnimeStore.Controllers
{
    public class FigureController : Controller
    {
        private readonly IFigureRepository _figureRepository;

        public FigureController(IFigureRepository figureRepository)
        {
            _figureRepository = figureRepository;
        }

        public IActionResult Index()
        {
            var result = _figureRepository.GetAll();

            return View(result);
        }

        public IActionResult Detail(int id)
        {
            var result = _figureRepository.GetById(id);

            return View(result);
        }

        [Route("figure/create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("figure/create")]
        public IActionResult Create(Figure model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            _figureRepository.Save(model);

            ViewBag.Message = "Created with success!";

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var result = _figureRepository.GetById(id);

            return View(result);
        }

        [HttpPost]
        [Route("figure/edit")]
        public IActionResult Edit(Figure model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            _figureRepository.Update(model);

            ViewBag.Message = "Modified with success!";

            return RedirectToAction("Index");
        }

        public IActionResult Remove(int id)
        {
            var result = _figureRepository.GetById(id);
            _figureRepository.Delete(result);

            return RedirectToAction("Index");
        }
    }
}
