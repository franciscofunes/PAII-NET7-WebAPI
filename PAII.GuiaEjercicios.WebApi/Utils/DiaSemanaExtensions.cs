using PAII.GuiaEjercicios.WebApi.Enums;

namespace PAII.GuiaEjercicios.WebApi.Utils
{
    public static class DiaSemanaExtensions
    {
        public static string GetImprimirTexto(this DiaSemana diaSemana)
        {
            var memberInfo = diaSemana.GetType().GetMember(diaSemana.ToString())[0];
            var attributes = memberInfo.GetCustomAttributes(typeof(ImprimirTextoAttribute), false);
            return ((ImprimirTextoAttribute)attributes[0]).Texto;
        }
    }
}