using Common.DTOs;
//using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Service.Interfaces
{
    public interface IService<T>
    {
        Task<T> GetAsync(string id);
        Task<T> GetAsync(int id);
        Task<List<T>> GetAllAsync();
        Task<List<T>> AddAsync(T entity);
    }
}
