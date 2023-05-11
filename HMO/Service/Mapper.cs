using AutoMapper;
using Common.DTOs;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Member, MemberDTO>().ReverseMap();
            CreateMap<Vaccine, VaccineDTO>().ReverseMap();
        }
    }
}
