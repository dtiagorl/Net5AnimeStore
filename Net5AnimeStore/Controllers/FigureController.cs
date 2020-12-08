using Microsoft.AspNetCore.Mvc;
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
    }
}
