using L5R_Reference_BE.Enums;
using L5R_Reference_BE.Models;
using L5R_Reference_BE.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace L5R_Reference_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahoController : ControllerBase
    {
        private const TechniqueType _type = TechniqueType.Maho;
        private readonly TechniqueService _techniqueService;
        public MahoController(TechniqueService techniqueService)
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
