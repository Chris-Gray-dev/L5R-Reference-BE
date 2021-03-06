using L5R_Reference_BE.Enums;
using L5R_Reference_BE.Models;
using L5R_Reference_BE.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace L5R_Reference_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechniquesController : ControllerBase
    {

        private readonly TechniqueService _techniqueService;

        public TechniquesController(TechniqueService techniqueService)  
        {
            _techniqueService = techniqueService;
        }

        [HttpGet]
        public async Task<List<Technique>> Get() =>
            await _techniqueService.GetAsync();


        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<Technique?>> Get(string id)
        {
            var technique = await _techniqueService.GetAsync(id);
            if (technique == null)
            {
                return NotFound();
            }
            return technique;
        }
    }
}
