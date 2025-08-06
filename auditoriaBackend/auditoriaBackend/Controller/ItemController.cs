using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Linq;

[ApiController]
[Route("api/[controller]")]
public class ItemController : ControllerBase
{
    private readonly ItemRepositorio _repo = new ItemRepositorio();

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_repo.Get());
    }

    [HttpPost]
    public IActionResult Post([FromBody] Item item)
    {
        _repo.Post(item);
        return Ok(item);
    }

    [HttpPut("{id}")]
    public IActionResult Delete(int id) // este es el "Put" que actúa como Delete analógico
    {
        bool eliminado = _repo.Put(id);
        return eliminado ? Ok("Eliminado") : NotFound();
    }

    [HttpPatch]
    public IActionResult Update([FromBody] Item item)
    {
        bool actualizado = _repo.Update(item);
        return actualizado ? Ok(item) : NotFound();
    }

}
