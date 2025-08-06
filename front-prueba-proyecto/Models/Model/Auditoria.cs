public class Auditoria
{
    public int IdAuditoria { get; set; }
    public string Titulo { get; set; }
    public Ubicacion Ubicacion { get; set; }
    public DateTime Fecha { get; set; }

    public List<Encuesta> Encuestas { get; set; } = new();
}