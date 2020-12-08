using Net5AnimeStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net5AnimeStore.Repository.Interface
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();

        User GetById(int id);

        void Save(User model);

        void Update(User model);

        void Delete(User model);
    }
}
