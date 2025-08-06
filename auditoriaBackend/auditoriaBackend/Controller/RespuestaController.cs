using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class RespuestaController : ControllerBase
{
    private readonly RespuestaRepositorio _repo = new RespuestaRepositorio();

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_repo.Get());
    }

    [HttpPost]
    public IActionResult Post([FromBody] Respuesta entity)
    {
        _repo.Post(entity);
        return Ok(entity);
    }

    [HttpPut("{id}")]
    public IActionResult Delete(int id)
    {
        var ok = _repo.Put(id);
        return ok ? Ok("Eliminado") : NotFound();
    }

    [HttpPatch]
    public IActionResult Update([FromBody] Respuesta entity)
    {
        var ok = _repo.Update(entity);
        return ok ? Ok(entity) : NotFound();
    }
}
