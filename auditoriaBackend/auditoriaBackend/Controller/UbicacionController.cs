using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class UbicacionController : ControllerBase
{
    private readonly UbicacionRepositorio _repo = new UbicacionRepositorio();

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_repo.Get());
    }

    [HttpPost]
    public IActionResult Post([FromBody] Ubicacion ubicacion)
    {
        _repo.Post(ubicacion);
        return Ok(ubicacion);
    }

    [HttpPut("{id}")]
    public IActionResult Delete(int id)
    {
        bool eliminado = _repo.Put(id);
        return eliminado ? Ok("Eliminado") : NotFound();
    }

    [HttpPatch]
    public IActionResult Update([FromBody] Ubicacion ubicacion)
    {
        bool actualizado = _repo.Update(ubicacion);
        return actualizado ? Ok(ubicacion) : NotFound();
    }
}
