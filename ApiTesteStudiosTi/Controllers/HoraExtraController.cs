using ApiTesteStudiosTi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiTesteStudiosTi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HoraExtraController : ControllerBase
    {
        private readonly IHoraExtraService _service;
        public HoraExtraController(IHoraExtraService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] int id, int qtdHoraExtra)
        {
            var resumoHoraextra = await _service.GetHoraExtra(id, qtdHoraExtra);

            return resumoHoraextra != null ? Ok(resumoHoraextra) : NotFound("Resumo não encontrado");
        }
    }
}
