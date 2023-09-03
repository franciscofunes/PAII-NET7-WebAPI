using PAII.GuiaEjercicios.WebApi.Enums;

namespace PAII.GuiaEjercicios.WebApi.Services.Enumeraciones
{
    public interface IEnumeracionesService
    {
        IEnumerable<string> ObtenerDiasSemana();
    }
}