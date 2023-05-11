using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOs
{
    public class MemberDTO
    {
        public string FullName { get; set; } = null!;

        public string Id { get; set; } = null!;

        public string Adress { get; set; } = null!;

        public DateTime BirthDate { get; set; }

        public string Telephone { get; set; } = null!;

        public string MobilePhone { get; set; } = null!;


        public DateTime DateOfPositiveResult { get; set; }

        public DateTime DateOfRecovery { get; set; }

        public virtual ICollection<VaccineDTO> Vaccines { get; set; } = new List<VaccineDTO>();
    }
}
