using L5R_Reference_BE.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace L5R_Reference_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechniqueTypesController : ControllerBase
    {
        private readonly TechniqueTypeService _techniqueTypeService;
        public TechniqueTypesController(TechniqueTypeService techniqueTypeService)
        {
            _techniqueTypeService = techniqueTypeService;
        }

        [HttpGet]
        public Dictionary<int, string> Get()
        {
            return _techniqueTypeService.GetTechniqueTypes();
        }

        [HttpGet("{id:length(1)}")]
        public string Get(string id)
        {
            return _techniqueTypeService.GetTechniqueType(int.Parse(id));
        }
    }
}
