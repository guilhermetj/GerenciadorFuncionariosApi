using ApiTesteStudiosTi.Data.Dtos;
using ApiTesteStudiosTi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiTesteStudiosTi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfissionalController : ControllerBase
    {
        private readonly IProfissionalService _service;
        public ProfissionalController(IProfissionalService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var profissional = await _service.Get();


            return profissional.Any()
                                ? Ok(profissional)
                                : NoContent();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var profissional = await _service.GetById(id);


            return profissional != null ? Ok(profissional) : NotFound("Profissional não encontrado");
        }
        [HttpPost]
        public async Task<IActionResult> Create(ProfissionalCreateDto request)
        {
           return await _service.Create(request) ? Ok("Profissional criado com sucesso") : BadRequest("Error ao criar Profissional");
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ProfissionalUpdateDto request)
        {
            return await _service.Update(id, request) ? Ok("Profissional editado com sucesso") : BadRequest("Error ao editar Profissional");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return await _service.Delete(id) ? Ok("Profissional deletado com sucesso") : BadRequest("Error ao deletar Profissional");
        }
    }
}
