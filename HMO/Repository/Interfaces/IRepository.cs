using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IRepository<T>
    {
        Task<T> GetAsync(int id);
        Task<T> GetAsync(string id);
        Task<List<T>> GetAllAsync();
        Task<List<T>> AddAsync(T entity);

    }
}
