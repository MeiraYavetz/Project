using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Interfaces;
using Repository.Interfaces;
using Repository.Entities;
using AutoMapper;
using Common.DTOs;

namespace Service.Service
{
    public class Memberservice : IService<MemberDTO>
    {
        private readonly IRepository<Member> _MemberRepository;
        private readonly IMapper _mapper;

        public Memberservice(IMapper mapper, IRepository<Member> MemberRepository)
        {
            _mapper = mapper;
            _MemberRepository = MemberRepository;
        }





        public async Task<List<MemberDTO>> AddAsync(MemberDTO entity)
        {
            var c = await _MemberRepository.AddAsync(_mapper.Map<Member>(entity));
            return _mapper.Map<List<MemberDTO>>(c);
        }



        public async Task<List<MemberDTO>> GetAllAsync()
        {
            return _mapper.Map<List<MemberDTO>>(await _MemberRepository.GetAllAsync());

        }

        public async Task<MemberDTO> GetAsync(string id)
        {
            return _mapper.Map<MemberDTO>(await _MemberRepository.GetAsync(id));
        }

        public Task<MemberDTO> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
