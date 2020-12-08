using Net5AnimeStore.Models;
using Net5AnimeStore.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net5AnimeStore.Repository
{
    public class GameRepository : IGameRepository
    {
        public void Delete(Game model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Game> GetAll()
        {
            return new List<Game>()
            {
                new Game()
                {
                    Id = 1,
                    Name = "PS4 - Monster Hunter: World",
                    ShortDescription = "IN STOCK!",
                    LongDescription = "New, Never Opened and box in EXCELLENT condition!",
                    Price = 480.00M,
                    ImageUrl = "https://via.placeholder.com/200"
                },
                new Game()
                {
                    Id = 2,
                    Name = "PS4 - Devil May Cry HD Collection COMPLETE EDITION E-capcom Limited Edition",
                    ShortDescription = "PS4 software Devil May Cry HD Collection",
                    LongDescription = "E-Capcom Limited : Replacement jacket",
                    Price = 1272.00M,
                    ImageUrl = "https://via.placeholder.com/200"
                }
            };
        }

        public Game GetById(int id)
        {
            return new Game()
            {
                Id = 1,
                Name = "PS4 - Monster Hunter: World",
                ShortDescription = "IN STOCK!",
                LongDescription = "New, Never Opened and box in EXCELLENT condition!",
                Price = 480.00M,
                ImageUrl = "https://via.placeholder.com/200"
            };
        }

        public void Save(Game model)
        {
            throw new NotImplementedException();
        }

        public void Update(Game model)
        {
            throw new NotImplementedException();
        }
    }
}
