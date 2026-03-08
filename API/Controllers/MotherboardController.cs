using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/motherboards")]
public class MotherboardsController : BaseController
{
    private readonly IMotherboardService _service;

    public MotherboardsController(IMotherboardService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _service.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        return Ok(await _service.GetByIdAsync(id));
    }

    [HttpPost]
    public async Task<IActionResult> Create(string socket, string chipset)
    {
        return Ok(await _service.CreateAsync(socket, chipset));
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, string socket, string chipset)
    {
        await _service.UpdateAsync(id, socket, chipset);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _service.DeleteAsync(id);
        return NoContent();
    }
}
