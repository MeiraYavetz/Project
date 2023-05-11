using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Repository.Entities;
using Repository.Interfaces;

namespace Repository.Repository
{

    public class MemberRepository : IRepository<Member>
    {
        private readonly IContext _context;
        public MemberRepository(IContext context)
        {
            _context = context;
        }

        public async Task<List<Member>> AddAsync(Member entity)
        {
            await _context.Members.AddAsync(entity);
            await _context.SaveChangesAsync();
            return await _context.Members.ToListAsync();
            
        }

        public async Task<List<Member>> GetAllAsync()
        {
            return await _context.Members.ToListAsync();

        }

        public async Task<Member> GetAsync(string id)
        {
            return await _context.Members.SingleAsync(e => e.Id == id);
        }

        public Task<Member> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
