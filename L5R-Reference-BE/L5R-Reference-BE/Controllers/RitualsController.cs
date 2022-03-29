using L5R_Reference_BE.Enums;
using L5R_Reference_BE.Services;
using L5R_Reference_BE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace L5R_Reference_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RitualsController : ControllerBase
    {

        private const TechniqueType _type = TechniqueType.Ritual;
        private readonly TechniqueService _techniqueService;
        public RitualsController(TechniqueService techniqueService)
        {
            _techniqueService = techniqueService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Technique>>> Get()
        {
            return await _techniqueService.GetTypeAsync(_type);
        }

        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<Technique?>> Get(string id)
        {
            var technique = await _techniqueService.GetIdByTypeAsync(_type, id);
            if (technique == null)
            {
                return NotFound();
            }
            return technique;
        }
    }
}
