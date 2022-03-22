using L5R_Reference_BE.Enums;
using L5R_Reference_BE.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace L5R_Reference_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RingsController : ControllerBase
    {
        private readonly RingService _ringService;

        public RingsController(RingService ringService)
        {
            _ringService = ringService;
        }

        [HttpGet]
        public Dictionary<int,string> Get()
        {
            return _ringService.GetRings();
        }


        [HttpGet("{id:length(1)}")]
        public string Get(string id)
        {
            return _ringService.GetRing(int.Parse(id));
        }
    }
}
