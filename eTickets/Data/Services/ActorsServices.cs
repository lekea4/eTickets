using eTickets.Data.RepositoryServices;
using eTickets.Data.Services.Interfaces;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class ActorsServices : RepositoryService<Actor>, IActorsServices
    {
        private readonly AppDbContext _context;

        public ActorsServices( AppDbContext context) : base (context)
        {
            _context = context;
        }

        public async Task AddAsync(Actor actor)
        {
           await _context.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public Task DeleteAsync(Actor actor)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var result = await  _context.Actors.ToListAsync();
            return result; 
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
          
            return result;
        }

        public Task UpdateAsync(Actor newActor, int id)
        {
            throw new NotImplementedException();
        }
    }
}
