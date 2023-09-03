namespace PAII.GuiaEjercicios.WebApi.Models;

public class ConversionResult
{
    public bool ResultadoConvertir { get; set; }
    public string? ExplicacionConvertir { get; set; }
    public bool ResultadoParsear { get; set; }
    public string? ExplicacionParsear { get; set; }
    public bool ResultadoTryParsear { get; set; }
    public string? ExplicacionTryParsear { get; set; }
}
