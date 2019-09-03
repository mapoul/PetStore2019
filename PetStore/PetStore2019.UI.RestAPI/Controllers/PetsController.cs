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
        private readonly IPetService _petService;
        public PetsController(IPetService petService)
        {
            _petService = petService;
        }

        [HttpGet]
        public ActionResult<List<Pet>> Get()
        {
            return _petService.GetPets();
        }
    }
}