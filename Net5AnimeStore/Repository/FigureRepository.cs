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
        public void Delete(Figure model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Figure> GetAll()
        {
            return new List<Figure>()
            {
                new Figure()
                {
                    Id = 1,
                    Name = "Fate/Grand Order - Lancer/Scathach",
                    ShortDescription = "Japanese Version!",
                    LongDescription = "New, Never Opened and box in EXCELLENT condition!",
                    Price = 1110.00M,
                    ImageUrl = "https://via.placeholder.com/200"
                },
                new Figure()
                {
                    Id = 2,
                    Name = "Fate/Grand Order - ConoFig Shielder/Matthew Kyrielite",
                    ShortDescription = "Aniplex Plus Exclusive Item",
                    LongDescription = "New, Never Opened and box in EXCELLENT condition!",
                    Price = 329.00M,
                    ImageUrl = "https://via.placeholder.com/200"
                }
            };
        }

        public Figure GetById(int id)
        {
            return new Figure()
            {
                Id = 1,
                Name = "Fate/Grand Order - Lancer/Scathach",
                ShortDescription = "Japanese Version!",
                LongDescription = "New, Never Opened and box in EXCELLENT condition!",
                Price = 1110.00M,
                ImageUrl = "https://via.placeholder.com/200"
            };
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
