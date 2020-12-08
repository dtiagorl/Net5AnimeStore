using Net5AnimeStore.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net5AnimeStore.Repository
{
    public class ConsoleRepository : IConsoleRepository
    {
        private readonly SenacContext _context;

        public ConsoleRepository(SenacContext context)
        {
            _context = context;
        }

        public void Delete(Models.Console model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Models.Console> GetAll()
        {
            return _context.Consoles.ToList();
        }

        public Models.Console GetById(int id)
        {
            return _context.Consoles.Where(x => x.Id == id).FirstOrDefault();
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
