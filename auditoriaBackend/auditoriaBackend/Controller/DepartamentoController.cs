using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class DepartamentoController : ControllerBase
{
    private readonly DepartamentoRepositorio _repo = new DepartamentoRepositorio();

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_repo.Get());
    }

    [HttpPost]
    public IActionResult Post([FromBody] Departamento departamento)
    {
        _repo.Post(departamento);
        return Ok(departamento);
    }

    [HttpPut("{id}")]
    public IActionResult Delete(int id)
    {
        bool eliminado = _repo.Put(id);
        return eliminado ? Ok("Eliminado") : NotFound();
    }

    [HttpPatch]
    public IActionResult Update([FromBody] Departamento departamento)
    {
        bool actualizado = _repo.Update(departamento);
        return actualizado ? Ok(departamento) : NotFound();
    }
}
