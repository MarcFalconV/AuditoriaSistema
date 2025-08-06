using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class SeccionController : ControllerBase
{
    private readonly SeccionRepositorio _repo = new SeccionRepositorio();

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_repo.Get());
    }

    [HttpPost]
    public IActionResult Post([FromBody] Seccion entity)
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
    public IActionResult Update([FromBody] Seccion entity)
    {
        var ok = _repo.Update(entity);
        return ok ? Ok(entity) : NotFound();
    }
}
