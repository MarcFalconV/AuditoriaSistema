public class Seguimiento
{
    public int IdSeguimiento { get; set; }
    public int IdRespuesta { get; set; }
    public string Estado { get; set; }
    public string Descripcion { get; set; }
    public string Supervisor { get; set; }
    public string ResponsableTratamiento { get; set; }
    public string ResponsableImplementacion { get; set; }
    public string Evidencia { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }
    public string ObservacionEstado { get; set; }
}
