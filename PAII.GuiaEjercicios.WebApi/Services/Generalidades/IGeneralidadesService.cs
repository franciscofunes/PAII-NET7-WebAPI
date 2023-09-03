using PAII.GuiaEjercicios.WebApi.Models;

namespace PAII.GuiaEjercicios.WebApi.Services.Generalidades
{
    public interface IGeneralidadesService
    {
        double Sumar(double numero1, double numero2);

        string CortarCadena(string cadena);

        DateTime ObtenerFechaHoraActual();

        CommentsTypes ObtenerComentariosCSharp();
    }
}