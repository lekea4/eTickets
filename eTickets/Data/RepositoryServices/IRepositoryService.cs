using eTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.RepositoryServices
{
    public interface IRepositoryService<T> where T : class, IEntityBase, new()
    {
        Task <IEnumerable<T>> GetAll();
        Task<T>  GetById(int id);
        Task<T> Add(T model);
        Task  Update(int id, T model);

        Task Delete(int id);
    }
}
