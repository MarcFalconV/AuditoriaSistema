using front_prueba_proyecto.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models.DTOs;

public class EncuestaModel : PageModel
{
    private readonly HttpClient _httpClient;

    public EncuestaModel(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient();
    }


    public List<AuditoriaDetalleDto> ResultadosAuditoriaDetalle { get; set; } = new();
    public List<RespuestaDetalleDto> ResultadosRespuesta { get; set; } = new();


    public async Task OnGetAsync()
    {
        var urlAuditorias = "http://localhost:5271/api/AuditoriaDetalleDto/auditoriaDetallado";
        var urlRespuestas = "http://localhost:5271/api/RespuestaDetalleRepositorio";

        try
        {
            var dataAuditorias = await _httpClient.GetFromJsonAsync<List<AuditoriaDetalleDto>>(urlAuditorias);
            ResultadosAuditoriaDetalle = dataAuditorias ?? new List<AuditoriaDetalleDto>();
        }
        catch
        {
            ResultadosAuditoriaDetalle = new List<AuditoriaDetalleDto>();
        }

        try
        {
            var dataRespuestas = await _httpClient.GetFromJsonAsync<List<RespuestaDetalleDto>>(urlRespuestas);
            ResultadosRespuesta = dataRespuestas ?? new List<RespuestaDetalleDto>();
        }
        catch
        {
            ResultadosRespuesta = new List<RespuestaDetalleDto>();
        }
    }



}


