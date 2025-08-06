using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class FacultadController : ControllerBase
{
    private readonly FacultadRepositorio _repo = new FacultadRepositorio();

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_repo.Get());
    }

    [HttpPost]
    public IActionResult Post([FromBody] Facultad facultad)
    {
        _repo.Post(facultad);
        return Ok(facultad);
    }

    [HttpPut("{id}")]
    public IActionResult Delete(int id)
    {
        bool eliminado = _repo.Put(id);
        return eliminado ? Ok("Eliminado") : NotFound();
    }

    [HttpPatch]
    public IActionResult Update([FromBody] Facultad facultad)
    {
        bool actualizado = _repo.Update(facultad);
        return actualizado ? Ok(facultad) : NotFound();
    }
}
