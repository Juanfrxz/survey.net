using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Apisurvey.Controllers;

public class QuestionController : BaseApiController
{
    private readonly IUnitOfWork _unitOfWork;
    public QuestionController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Question>>> Get()
    {
        var question = await _unitOfWork.Questions.GetAllAsync();
        return Ok(question);
    }
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get(int id)
    {
        var question = await _unitOfWork.Questions.GetByIdAsync(id);
        if (question == null)
        {
            return NotFound();
        }
        return Ok(question);
    }
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Question>> Post(Question question)
    {
        _unitOfWork.Questions.Add(question);
        await _unitOfWork.SaveAsync();
        return CreatedAtAction(nameof(Get), new { id = question.Id }, question);
    }
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Put(int id, [FromBody] Question question)
    {
        // Validación: objeto nulo
        if (question == null)
            return BadRequest("El cuerpo de la solicitud está vacío.");

        // Validación: el ID de la URL debe coincidir con el del objeto (si viene con ID)
        if (id != question.Id)
            return BadRequest("El ID de la URL no coincide con el ID del objeto enviado.");

        // Verificación: el recurso debe existir antes de actualizar
        var existingQuestion = await _unitOfWork.Questions.GetByIdAsync(id);
        if (existingQuestion == null)
            return NotFound($"No se encontró el país con ID {id}.");

        // Actualización controlada de campos específicos
        existingQuestion.QuestionText = question.QuestionText; // Actualiza el texto de la pregunta recibido
        // Puedes agregar más propiedades aquí según el modelo

        _unitOfWork.Questions.Update(existingQuestion);
        await _unitOfWork.SaveAsync();

        return Ok(existingQuestion);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var question = await _unitOfWork.Questions.GetByIdAsync(id);
        if (question == null)
            return NotFound();

        _unitOfWork.Questions.Remove(question);
        await _unitOfWork.SaveAsync();

        return NoContent();
    }
}
