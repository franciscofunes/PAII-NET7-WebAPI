using Microsoft.AspNetCore.Mvc;
using PAII.GuiaEjercicios.WebApi.Models;
using PAII.GuiaEjercicios.WebApi.Services.Generalidades;

namespace PAII.GuiaEjercicios.WebApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class GeneralidadesController : ControllerBase
    {
        private readonly IGeneralidadesService _generalidadesService;

        public GeneralidadesController(IGeneralidadesService generalidadesService)
        {
            _generalidadesService = generalidadesService;
        }

        /// <summary>
        /// Realiza la suma de dos números.
        /// </summary>
        /// <remarks>
        /// Este endpoint toma dos números como entrada y devuelve su suma.
        /// </remarks>
        /// <param name="numero1">El primer número a sumar.</param>
        /// <param name="numero2">El segundo número a sumar.</param>
        /// <returns>Un objeto JSON que contiene el resultado de la suma.</returns>
        [HttpGet("suma")]
        public IActionResult Suma([FromQuery(Name = "numero1")] double numero1, [FromQuery(Name = "numero2")] double numero2)
        {
            double resultado = _generalidadesService.Sumar(numero1, numero2);

            return Ok(new
            {
                Resultado = resultado,
                Descripcion = $"Este endpoint toma dos números como entrada y devuelve su suma. La suma de {numero1} y {numero2} es igual a {resultado}."
            });
        }

        /// <summary>
        /// Corta una cadena de 8 caracteres.
        /// </summary>
        /// <param name="cadena">La cadena de entrada que se cortará.</param>
        /// <remarks>
        /// Este endpoint recibe una cadena de 8 caracteres y devuelve los primeros 4 caracteres.
        /// Si la cadena no tiene 8 caracteres, se devuelve un error.
        /// </remarks>
        /// <param name="cadena">La cadena de entrada que se cortará.</param>
        /// <returns>Un objeto JSON que contiene los primeros 4 caracteres de la cadena.</returns>
        [HttpGet("cortar/{cadena}")]
        public IActionResult CortarCadena(string cadena)
        {
            try
            {
                string resultado = _generalidadesService.CortarCadena(cadena);

                return Ok(new
                {
                    Primeros4Caracteres = resultado,
                    Descripcion = $"Este endpoint recibe una cadena de 8 caracteres y devuelve los primeros 4 caracteres de la cadena '{cadena}'."
                });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Obtiene la fecha y hora actual.
        /// </summary>
        /// <remarks>
        /// Este endpoint devuelve la fecha y hora actual del servidor.
        /// </remarks>
        /// <returns>Un objeto JSON que contiene la fecha y hora actual.</returns>
        [HttpGet("fecha")]
        public IActionResult FechaHoraActual()
        {
            DateTime fechaHoraActual = _generalidadesService.ObtenerFechaHoraActual();

            return Ok(new
            {
                FechaHoraActual = fechaHoraActual,
                Descripcion = "Este endpoint devuelve la fecha y hora actual del servidor."
            });
        }

        /// <summary>
        /// Este endpoint demuestra diferentes tipos de comentarios en C#.
        /// </summary>
        /// <returns>Ejemplos de comentarios en C#.</returns>
        [HttpGet("comentarios")]
        public IActionResult ComentariosCSharp()
        {
            CommentsTypes comentarios = _generalidadesService.ObtenerComentariosCSharp();

            return Ok(comentarios);
        }
    }
}
