using Net5AnimeStore.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net5AnimeStore.Repository
{
    public class ConsoleRepository : IConsoleRepository
    {
        public void Delete(Models.Console model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Models.Console> GetAll()
        {
            return new List<Models.Console>()
            {
                new Models.Console()
                {
                    Id = 1,
                    Name = "PlayStation 2 Slim White",
                    ShortDescription = "Rare White PlayStation 2 Slim",
                    LongDescription = "PlayStation 2 Slim rare white color, sold only in Japan, sealed box!",
                    Price = 1500.00M,
                    ImageUrl = "https://via.placeholder.com/200"
                },
                new Models.Console()
                {
                    Id = 2,
                    Name = "PlayStation 5",
                    ShortDescription = "Brand new PlayStation 5",
                    LongDescription = "PlayStation 5 new console, plus 1 free month of PSN plus subscription! (Redeem Card)",
                    Price = 4500.00M,
                    ImageUrl = "https://via.placeholder.com/200"
                }
            };
        }

        public Models.Console GetById(int id)
        {
            return new Models.Console()
            {
                Id = 1,
                Name = "PlayStation 2 Slim White",
                ShortDescription = "Rare White PlayStation 2 Slim",
                LongDescription = "PlayStation 2 Slim rare white color, sold only on Japan, sealed on box!",
                Price = 1500.00M,
                ImageUrl = "https://via.placeholder.com/200"
            };
        }

        public void Save(Models.Console model)
        {
            throw new NotImplementedException();
        }

        public void Update(Models.Console model)
        {
            throw new NotImplementedException();
        }
    }
}
