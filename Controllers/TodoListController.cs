using Microsoft.AspNetCore.Mvc;
using PAII_Net7_WebApi.Models;

namespace PAII_Net7_WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListaTareasController : ControllerBase
    {
        private static readonly string[] Descripciones = new[]
        {
            "Hacer compras", "Llamar a cliente", "Estudiar para el examen", "Hacer ejercicio", "Limpieza"
        };

        private readonly ILogger<ListaTareasController> _logger;

        public ListaTareasController(ILogger<ListaTareasController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "ObtenerListaTareas")]
        public IEnumerable<Tarea> ObtenerListaTareas()
        {
            return Enumerable.Range(1, 5).Select(index => new Tarea
            {
                Id = Guid.NewGuid(),
                Descripcion = Descripciones[Random.Shared.Next(Descripciones.Length)],
                EstaCompletada = Random.Shared.NextDouble() > 0.5
            })
            .ToArray();
        }
    }
}
