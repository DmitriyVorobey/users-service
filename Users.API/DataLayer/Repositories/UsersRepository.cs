using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using Users.API.DataLayer.Model;

namespace Users.API.DataLayer.Repositories
{
    // TODO: Add mssql repository
    public class InMemoryUsersRepository : IUsersRepository
    {
        private List<User> _users = new List<Model.User>()
        {
            new Model.User(Guid.NewGuid(), "oreshko@gmail.com", "Vasya", "Oreshko"),
            new Model.User(Guid.NewGuid(), "oleg@gmail.com", "Oleg", "Petrenko"),
        };

        public async Task<User> GetUser(Guid id)
        {
            return await Task.FromResult(_users.FirstOrDefault(x => x.Id == id));
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await Task.FromResult(_users.FirstOrDefault(x => x.Email == email));
        }

        public Task CreateUser(Model.User user)
        {
            _users.Add(user);
            return Task.CompletedTask;
        }
    }
}
