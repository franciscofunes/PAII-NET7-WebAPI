using Microsoft.AspNetCore.Mvc;
using PAII.GuiaEjercicios.WebApi.Enums;
using PAII.GuiaEjercicios.WebApi.Models;
using PAII.GuiaEjercicios.WebApi.Services;

namespace PAII.GuiaEjercicios.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConversionesController : ControllerBase
    {
        private readonly IConversionesService _conversionesService;

        public ConversionesController(IConversionesService conversionesService)
        {
            _conversionesService = conversionesService;
        }

        [HttpGet("realizar-conversiones")]
        public IActionResult RealizarConversiones([FromQuery] bool valor)
        {
            var resultadosConversion = _conversionesService.RealizarConversiones(valor);
            return Ok(resultadosConversion);
        }

        [HttpGet("explicar-casteos")]
        public IActionResult ExplicarCasteos()
        {
            IEnumerable<ExplicacionCasteo> explicaciones = _conversionesService.ExplicarCasteos();
            return Ok(explicaciones);
        }

        [HttpGet("mensaje-color/{color}")]
        public IActionResult ObtenerMensajeColor(Colores color)
        {
            string mensaje = _conversionesService.ObtenerMensajeColor(color);

            return Ok(new { Mensaje = mensaje });
        }

        [HttpGet("evaluar-variable-a/{a}")]
        public IActionResult EvaluarVariableA(int a)
        {
            string mensaje = _conversionesService.EvaluarVariableA(a);

            return Ok(new { Mensaje = mensaje });
        }

        [HttpGet("diferencia-for-foreach")]
        public IActionResult ExplicarDiferenciaForForeach()
        {
            string explicacion = _conversionesService.ExplicarDiferenciaForForeach();
            return Ok(explicacion);
        }

        [HttpGet("incrementar-variable")]
        public IActionResult IncrementarVariable([FromQuery] int valorInicial)
        {
            const int ValorMaximo = 50;

            if (valorInicial > ValorMaximo)
            {
                return BadRequest("El valor inicial no puede ser mayor que el valor máximo permitido.");
            }

            int resultado = _conversionesService.IncrementarVariable(valorInicial); // Updated variable name

            return Ok(new { ValorFinal = resultado });
        }
    }
}
