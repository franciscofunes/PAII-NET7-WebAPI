namespace PAII_Net7_WebApi.Models;

public class Tarea
{
    public Guid Id { get; set; }
    public string? Descripcion { get; set; }
    public bool EstaCompletada { get; set; }
}