using Net5AnimeStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net5AnimeStore.Repository.Interface
{
    public interface IFigureRepository
    {
        IEnumerable<Figure> GetAll();
        Figure GetById(int id);
        void Save(Figure model);
        void Update(Figure model);
        void Delete(Figure model);
    }
}
