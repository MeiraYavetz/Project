using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOs
{
    public class VaccineDTO
    {
        public DateTime? DateOfVaccine { get; set; }

        public string? VaccineManuFacturer { get; set; }

        public int IdVaccine { get; set; }
        public string? IdMember { get; set; }
    }
}
