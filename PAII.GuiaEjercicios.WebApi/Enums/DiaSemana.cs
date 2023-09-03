namespace PAII.GuiaEjercicios.WebApi.Enums
{
    public enum DiaSemana
    {
        [ImprimirTexto("Domingo")]
        Domingo = 1,
        [ImprimirTexto("Lunes")]
        Lunes,
        [ImprimirTexto("Martes")]
        Martes,
        [ImprimirTexto("Miércoles")]
        Miércoles,
        [ImprimirTexto("Jueves")]
        Jueves,
        [ImprimirTexto("Viernes")]
        Viernes,
        [ImprimirTexto("Sábado")]
        Sábado
    }

    [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    sealed class ImprimirTextoAttribute : Attribute
    {
        public string Texto { get; }

        public ImprimirTextoAttribute(string texto)
        {
            Texto = texto;
        }
    }
}