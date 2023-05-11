using Common.DTOs;
using Microsoft.AspNetCore.Mvc;
using Service.AlgorithmAndFunctions;
using Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HMO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlgorithmController : ControllerBase
    {
        private readonly IAlgorithm _algorithm;
        public AlgorithmController(IAlgorithm algorithm)
        {
            _algorithm = algorithm;
        }


        //GET: api/<ValuesController>
        [HttpGet]
        public async Task<int> Get()
        {
            return await _algorithm.howManyWithoutVaccine();
        }

       

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<int[]> Post([FromBody] DateDTO date)
        {
             return await _algorithm.howManySicks(date);
        }

       
    }
}
