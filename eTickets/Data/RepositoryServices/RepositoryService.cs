using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.RepositoryServices
{
    public class RepositoryService<T> : IRepositoryService<T> where T : class
    {
        private readonly AppDbContext _context;

        public RepositoryService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<T> Add(T model)
        {
            await _context.Set<T>().AddAsync(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async  Task Delete(int id)
        {
            _context.Remove(id);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async  Task<T> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async  Task Update( int id, T model)
        {
            _context.Update(model);
            await _context.SaveChangesAsync();
        }
    }
}
