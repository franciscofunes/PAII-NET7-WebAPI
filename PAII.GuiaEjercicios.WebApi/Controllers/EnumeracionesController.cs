using Microsoft.AspNetCore.Mvc;
using PAII.GuiaEjercicios.WebApi.Services.Enumeraciones;

namespace PAII.GuiaEjercicios.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnumeracionesController : ControllerBase
    {
        private readonly IEnumeracionesService _enumeracionesService;

        public EnumeracionesController(IEnumeracionesService enumeracionesService)
        {
            _enumeracionesService = enumeracionesService;
        }

        [HttpGet("dias-semana")]
        public IActionResult ObtenerDiasSemana()
        {
            IEnumerable<string> diasSemana = _enumeracionesService.ObtenerDiasSemana();
            return Ok(diasSemana);
        }
    }
}
