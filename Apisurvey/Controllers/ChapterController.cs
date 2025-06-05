using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Apisurvey.Controllers;

public class ChapterController : BaseApiController
{
    private readonly IUnitOfWork _unitOfWork;
    public ChapterController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Chapter>>> Get()
    {
        var chapter = await _unitOfWork.Chapters.GetAllAsync();
        return Ok(chapter);
    }
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get(int id)
    {
        var chapter = await _unitOfWork.Chapters.GetByIdAsync(id);
        if (chapter == null)
        {
            return NotFound();
        }
        return Ok(chapter);
    }
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Chapter>> Post(Chapter chapter)
    {
        _unitOfWork.Chapters.Add(chapter);
        await _unitOfWork.SaveAsync();
        return CreatedAtAction(nameof(Get), new { id = chapter.Id }, chapter);
    }
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Put(int id, [FromBody] Chapter chapter)
    {
        // Validación: objeto nulo
        if (chapter == null)
            return BadRequest("El cuerpo de la solicitud está vacío.");

        // Validación: el ID de la URL debe coincidir con el del objeto (si viene con ID)
        if (id != chapter.Id)
            return BadRequest("El ID de la URL no coincide con el ID del objeto enviado.");

        // Verificación: el recurso debe existir antes de actualizar
        var existingChapter = await _unitOfWork.Chapters.GetByIdAsync(id);
        if (existingChapter == null)
            return NotFound($"No se encontró el país con ID {id}.");


        // Actualización controlada de campos específicos
        existingChapter.ChapterNumber = chapter.ChapterNumber; // Actualiza el texto de la pregunta recibido
        existingChapter.ChapterTitle = chapter.ChapterTitle; // Actualiza el texto de la pregunta recibido
        existingChapter.ComponentHtml = chapter.ComponentHtml; // Actualiza el texto de la pregunta recibido
        existingChapter.ComponentReact = chapter.ComponentReact; // Actualiza el texto de la pregunta recibido
        existingChapter.SurveyId = chapter.SurveyId; // Actualiza el texto de la pregunta recibido
        // Puedes agregar más propiedades aquí según el modelo

        _unitOfWork.Chapters.Update(existingChapter);
        await _unitOfWork.SaveAsync();

        return Ok(existingChapter);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var chapter = await _unitOfWork.Chapters.GetByIdAsync(id);
        if (chapter == null)
            return NotFound();

        _unitOfWork.Chapters.Remove(chapter);
        await _unitOfWork.SaveAsync();

        return NoContent();
    }
}
