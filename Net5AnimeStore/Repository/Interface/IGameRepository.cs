using Net5AnimeStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net5AnimeStore.Repository.Interface
{
    public interface IGameRepository
    {
        IEnumerable<Game> GetAll();

        Game GetById(int id);

        void Save(Game model);

        void Update(Game model);

        void Delete(Game model);
    }
}
