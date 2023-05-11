using Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AlgorithmAndFunctions
{
    public interface IAlgorithm
    {
        public Task<int[]> howManySicks(DateDTO date);
        public Task<int> howManyWithoutVaccine();
    }
}
