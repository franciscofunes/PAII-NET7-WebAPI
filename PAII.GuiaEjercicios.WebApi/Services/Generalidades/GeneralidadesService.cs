using PAII.GuiaEjercicios.WebApi.Models;

namespace PAII.GuiaEjercicios.WebApi.Services.Generalidades
{
    public class GeneralidadesService : IGeneralidadesService
    {
        public double Sumar(double numero1, double numero2)
        {
            return numero1 + numero2;
        }

        public string CortarCadena(string cadena)
        {
            if (cadena.Length == 8)
            {
                return cadena.Substring(0, 4);
            }
            else
            {
                throw new ArgumentException("La cadena debe tener 8 caracteres.");
            }
        }

        public DateTime ObtenerFechaHoraActual()
        {
            return DateTime.Now;
        }

        public CommentsTypes ObtenerComentariosCSharp()
        {
            return new CommentsTypes
            {
                ComentarioUnaLinea = "// Este es un comentario de una sola línea con //",
                ComentarioMultilinea = "/*\n   Este es un comentario de varias líneas con /*\n   Puede abarcar múltiples líneas.\n*/"
            };
        }
    }
}