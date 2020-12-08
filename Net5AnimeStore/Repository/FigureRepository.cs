using Net5AnimeStore.Models;
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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void Update(Figure model)
        {
            throw new NotImplementedException();
        }
    }
}
