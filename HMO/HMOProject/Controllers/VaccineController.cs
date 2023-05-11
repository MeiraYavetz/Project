using Common.DTOs;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using Service.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HMO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccineController : ControllerBase
    {
        private readonly IService<VaccineDTO> _Vaccineservice;
        public VaccineController(IService<VaccineDTO> Vaccineservice)
        {
            _Vaccineservice = Vaccineservice;
        }
        // GET: api/<VaccineController>
        [HttpGet]
        public Task<List<VaccineDTO>> Get()
        {
            return _Vaccineservice.GetAllAsync();
        }

        // GET api/<VaccineController>/5
        [HttpGet("{id}")]
        public Task<VaccineDTO> Get(int id)
        {
            return _Vaccineservice.GetAsync(id);
        }

        // POST api/<VaccineController>
        [HttpPost]
        public Task<List<VaccineDTO>> Post([FromBody] VaccineDTO entity)
        {
            return _Vaccineservice.AddAsync(entity);
        }

        //// PUT api/<VaccineController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] VaccineDTO entity)
        //{

        //}

        //// DELETE api/<VaccineController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
