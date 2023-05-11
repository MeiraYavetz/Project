using AutoMapper;
using Common.DTOs;
using Repository.Entities;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class Vaccineservice:IService<VaccineDTO>
    {
        private readonly IRepository<Vaccine> _MemberRepository;
        private readonly IMapper _mapper;

        public Vaccineservice(IMapper mapper, IRepository<Vaccine> VaccineRepository)
        {
            _mapper = mapper;
            _MemberRepository = VaccineRepository;
        }

        public async Task<List<VaccineDTO>> AddAsync(VaccineDTO entity)
        {
            var c = await _MemberRepository.AddAsync(_mapper.Map<Vaccine>(entity));
            return _mapper.Map<List<VaccineDTO>>(c);
        }
        

        public async Task<List<VaccineDTO>> GetAllAsync()
        {
            return _mapper.Map<List<VaccineDTO>>(await _MemberRepository.GetAllAsync());

        }

        

        public async Task<VaccineDTO> GetAsync(int id)
        {
            return _mapper.Map<VaccineDTO>(await _MemberRepository.GetAsync(id));

        }
        public async Task<VaccineDTO> GetAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
