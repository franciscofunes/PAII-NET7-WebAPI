using PAII.GuiaEjercicios.WebApi.Enums;
using PAII.GuiaEjercicios.WebApi.Models;

namespace PAII.GuiaEjercicios.WebApi.Services
{
    public interface IConversionesService
    {
        ConversionResult RealizarConversiones(bool valor);

        IEnumerable<ExplicacionCasteo> ExplicarCasteos();

        string ObtenerMensajeColor(Colores color);

        string EvaluarVariableA(int a);

        string ExplicarDiferenciaForForeach();

        int IncrementarVariable(int valorInicial);
    }
}