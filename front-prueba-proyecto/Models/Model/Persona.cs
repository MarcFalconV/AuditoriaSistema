public class Persona
{
    public int IdPersona { get; set; }
    public string Nombre { get; set; }
    public string Correo { get; set; }

    public Rol Rol { get; set; }  // referencia directa al objeto Rol
}
