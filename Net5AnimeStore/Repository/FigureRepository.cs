﻿using Net5AnimeStore.Models;
using Net5AnimeStore.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net5AnimeStore.Repository
{
    public class FigureRepository : IFigureRepository
    {
        private readonly SenacContext _context;

        public FigureRepository(SenacContext context)
        {
            _context = context;
        }

        public void Delete(Figure model)
        {
            _context.Figures.Remove(model);
            _context.SaveChanges();
        }

        public IEnumerable<Figure> GetAll()
        {
            return _context.Figures.ToList();
        }

        public Figure GetById(int id)
        {
            return _context.Figures.Where(x => x.Id == id).FirstOrDefault();
        }

        public void Save(Figure model)
        {
            _context.Figures.Add(model);
            _context.SaveChanges();
        }

        public void Update(Figure model)
        {
            _context.Figures.Update(model);
            _context.SaveChanges();
        }
    }
}
