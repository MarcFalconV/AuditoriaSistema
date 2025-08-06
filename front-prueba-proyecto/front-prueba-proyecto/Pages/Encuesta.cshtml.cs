using front_prueba_proyecto.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class EncuestaModel : PageModel
{
    [BindProperty]
    public string Lugar { get; set; }

    [BindProperty]
    public string Facultad { get; set; }

    [BindProperty]
    public string Departamento { get; set; }

    public List<Encuestas> Resultados { get; set; }

    public void OnGet()
    {
        // Inicializar o limpiar
        Resultados = null;
    }

    public void OnPost()
    {
        // Aqu� har�as la consulta real a la base de datos usando los filtros recibidos
        // Por ahora simulo con datos est�ticos

        var datosFalsos = new List<Encuestas>
        {
            new Encuestas { Lugar = "Quito", Facultad = "Ingenier�a", Departamento = "Sistemas", ValorEncuesta = "Positivo" },
            new Encuestas { Lugar = "Quito", Facultad = "Ingenier�a", Departamento = "Electr�nica", ValorEncuesta = "Negativo" }
        };

        Resultados = datosFalsos
            .Where(x =>
                (string.IsNullOrEmpty(Lugar) || x.Lugar.Contains(Lugar)) &&
                (string.IsNullOrEmpty(Facultad) || x.Facultad.Contains(Facultad)) &&
                (string.IsNullOrEmpty(Departamento) || x.Departamento.Contains(Departamento)))
            .ToList();
    }
}
