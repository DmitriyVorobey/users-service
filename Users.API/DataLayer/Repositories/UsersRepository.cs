using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace Users.API.DataLayer.Repositories
{
    public class InMemoryUsersRepository : IUsersRepository
    {
        private List<Model.User> _users = new List<Model.User>()
        {
            new Model.User(Guid.NewGuid(), "oreshko@gmail.com", "Vasya", "Oreshko"),
            new Model.User(Guid.NewGuid(), "oleg@gmail.com", "Oleg", "Petrenko"),
        };

        public async Task<Model.User> GetUser(Guid id)
        {
            return await Task.FromResult(_users.FirstOrDefault(x => x.Id == id));
        }

        public Task CreateUser(Model.User user)
        {
            _users.Add(user);
            return Task.CompletedTask;
        }
    }
}
