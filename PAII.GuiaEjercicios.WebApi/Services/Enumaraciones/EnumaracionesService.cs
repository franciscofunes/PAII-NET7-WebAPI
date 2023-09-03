
using PAII.GuiaEjercicios.WebApi.Enums;
using PAII.GuiaEjercicios.WebApi.Utils;

namespace PAII.GuiaEjercicios.WebApi.Services.Enumeraciones
{
    public class EnumeracionesService : IEnumeracionesService
    {
        public IEnumerable<string> ObtenerDiasSemana()
        {
            var diasSemana = Enum.GetValues(typeof(DiaSemana))
                                 .Cast<DiaSemana>()
                                 .Select(d => d.GetImprimirTexto()); // Use GetImprimirTexto extension method
            return diasSemana;
        }
    }
}
