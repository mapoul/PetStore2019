using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetStore2019.Core.ApplicationServices;
using PetStore2019.Core.Entities;

namespace PetStore2019.UI.RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {

        // GET api/values
        [HttpGet]
        public ActionResult<List<Pet>> Get()
        {
            return _petService.GetPets();

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private readonly IPetService _petService;
        public PetsController(IPetService petService)
        {
            _petService = petService;
        }

        
    }
}