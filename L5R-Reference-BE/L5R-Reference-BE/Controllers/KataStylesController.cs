using L5R_Reference_BE.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace L5R_Reference_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KataStylesController : ControllerBase
    {
        private readonly KataStyleService _kataStyleService;
        public KataStylesController(KataStyleService kataStyleService)
        {
            _kataStyleService = kataStyleService;
        }

        [HttpGet]
        public Dictionary<int, string> Get()
        {
            return _kataStyleService.GetKataStyles();
        }

        [HttpGet("{id:length(1)}")]
        public string Get(string id)
        {
            return _kataStyleService.GetKataStyle(int.Parse(id));
        }
    }
}
