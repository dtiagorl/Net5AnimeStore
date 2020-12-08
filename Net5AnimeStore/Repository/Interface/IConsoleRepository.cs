using Net5AnimeStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Net5AnimeStore.Repository.Interface
{
    public interface IConsoleRepository
    {
        IEnumerable<Models.Console> GetAll();

        Models.Console GetById(int id);

        void Save(Models.Console model);

        void Update(Models.Console model);

        void Delete(Models.Console model);
    }
}
