
using Common.DTOs;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HMO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class memberController : ControllerBase
    {
        private readonly IService<MemberDTO> _Memberservice;
        public memberController(IService<MemberDTO> Memberservice)
        {
            _Memberservice = Memberservice;
        }
        // GET: api/<memberController>
        [HttpGet]
        public Task<List<MemberDTO>> Get()
        {
            return _Memberservice.GetAllAsync();
        }

        // GET api/<memberController>/5
        [HttpGet("{id}")]
        public Task<MemberDTO> Get(string id)
        {
            return _Memberservice.GetAsync(id);
        }

        // POST api/<memberController>
        [HttpPost]
        public Task<List<MemberDTO>> Post([FromBody] MemberDTO entity)
        {
            return _Memberservice.AddAsync(entity);
        }



        [HttpPost("upload")]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("Please select a file to upload.");

            // Save the file to the server
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "uploads", file.FileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return Ok();
        }



        //// PUT api/<memberController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<memberController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
