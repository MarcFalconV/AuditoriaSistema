using front_prueba_proyecto.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class EncuestaModel : PageModel
{
    private readonly HttpClient _httpClient;

    public EncuestaModel(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient();
    }

    [BindProperty]
    public string Lugar { get; set; }

    [BindProperty]
    public string Facultad { get; set; }

    [BindProperty]
    public string Departamento { get; set; }

    public List<Auditoria> Resultados { get; set; } = new();

    public void OnGet() { }

    public async Task<IActionResult> OnPostAsync()
    {
        try
        {
            // Construye tu URL con parámetros si es necesario
            var url = $"https://tuservicio/api/auditorias?lugar={Lugar}&facultad={Facultad}&departamento={Departamento}";

            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadFromJsonAsync<List<Auditoria>>();
                Resultados = data ?? new List<Auditoria>();
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Error al obtener datos del servidor.");
            }
        }
        catch (Exception ex)
        {
            ModelState.AddModelError(string.Empty, $"Error inesperado: {ex.Message}");
        }

        return Page();
    }
}


public class Auditoria
{
    public int IdAuditoria { get; set; }
    public string Titulo { get; set; }
    public string Ubicacion { get; set; }
    public string Facultad { get; set; }
    public string Departamento { get; set; }
    public string PersonaEncuestada { get; set; }
    public string Estado { get; set; }
    public DateTime Fecha { get; set; }
}
