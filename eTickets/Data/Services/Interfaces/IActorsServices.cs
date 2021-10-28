using eTickets.Data.RepositoryServices;
using eTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services.Interfaces
{
    public interface IActorsServices : IRepositoryService<Actor>
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Task UpdateAsync(Actor newActor, int id);

        Task DeleteAsync(Actor actor);
    }
}
