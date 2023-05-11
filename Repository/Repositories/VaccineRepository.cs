using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class VaccineRepository:IRepository<Vaccine>
    {
        private readonly IContext _context;
        public VaccineRepository(IContext context)
        {
            _context = context;
        }

        public async Task<List<Vaccine>> AddAsync(Vaccine entity)
        {
            await _context.Vaccines.AddAsync(entity);
            await _context.SaveChangesAsync();
            return await _context.Vaccines.ToListAsync();
        }

        public async Task<List<Vaccine>> GetAllAsync()
        {
            return await _context.Vaccines.ToListAsync();

        }

        public async Task<Vaccine> GetAsync(int id)
        {
            return await _context.Vaccines.SingleAsync(e => e.IdVaccine == id);

        }

        public Task<Vaccine> GetAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
