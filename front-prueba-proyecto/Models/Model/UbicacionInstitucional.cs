public class UbicacionInstitucional
{
    public int IdUbicacionInstitucional { get; set; }

    public Ubicacion Ubicacion { get; set; }      // referencia al objeto Ubicacion
    public Facultad Facultad { get; set; }        // referencia al objeto Facultad
    public Departamento Departamento { get; set; }  // referencia al objeto Departamento
}
