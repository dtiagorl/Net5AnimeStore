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
        private readonly SenacContext _context;

        public GameRepository(SenacContext context)
        {
            _context = context;
        }

        public void Delete(Game model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Game> GetAll()
        {
            return _context.Games.ToList();
        }

        public Game GetById(int id)
        {
            return _context.Games.Where(x => x.Id == id).FirstOrDefault();
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
