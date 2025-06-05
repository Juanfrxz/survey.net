using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Apisurvey.Controllers;

public class OptionsResponseController : BaseApiController
{
    private readonly IUnitOfWork _unitOfWork;
    public OptionsResponseController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<OptionsResponse>>> Get()
    {
        var optionsResponse = await _unitOfWork.OptionsResponses.GetAllAsync();
        return Ok(optionsResponse);
    }
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get(int id)
    {
        var optionsResponse = await _unitOfWork.OptionsResponses.GetByIdAsync(id);
        if (optionsResponse == null)
        {
            return NotFound();
        }
        return Ok(optionsResponse);
    }
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<OptionsResponse>> Post(OptionsResponse optionsResponse)
    {
        _unitOfWork.OptionsResponses.Add(optionsResponse);
        await _unitOfWork.SaveAsync();
        return CreatedAtAction(nameof(Get), new { id = optionsResponse.Id }, optionsResponse);
    }
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Put(int id, [FromBody] OptionsResponse optionsResponse)
    {
        // Validación: objeto nulo
        if (optionsResponse == null)
            return BadRequest("El cuerpo de la solicitud está vacío.");

        // Validación: el ID de la URL debe coincidir con el del objeto (si viene con ID)
        if (id != optionsResponse.Id)
            return BadRequest("El ID de la URL no coincide con el ID del objeto enviado.");

        // Verificación: el recurso debe existir antes de actualizar
        var existingOptionsResponse = await _unitOfWork.OptionsResponses.GetByIdAsync(id);
        if (existingOptionsResponse == null)
            return NotFound($"No se encontró el país con ID {id}.");

        // Actualización controlada de campos específicos
        existingOptionsResponse.OptionText = optionsResponse.OptionText; // Actualiza el texto de la pregunta recibido
        // Puedes agregar más propiedades aquí según el modelo

        _unitOfWork.OptionsResponses.Update(existingOptionsResponse);
        await _unitOfWork.SaveAsync();

        return Ok(existingOptionsResponse);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var optionsResponse = await _unitOfWork.OptionsResponses.GetByIdAsync(id);
        if (optionsResponse == null)
            return NotFound();

        _unitOfWork.OptionsResponses.Remove(optionsResponse);
        await _unitOfWork.SaveAsync();

        return NoContent();
    }
}
