using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Apisurvey.Controllers;

public class CategoriesCatalogController : BaseApiController
{
    private readonly IUnitOfWork _unitOfWork;
    public CategoriesCatalogController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<CategoriesCatalog>>> Get()
    {
        var categoriesCatalog = await _unitOfWork.CategoriesCatalogs.GetAllAsync();
        return Ok(categoriesCatalog);
    }
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get(int id)
    {
        var categoriesCatalog = await _unitOfWork.CategoriesCatalogs.GetByIdAsync(id);
        if (categoriesCatalog == null)
        {
            return NotFound();
        }
        return Ok(categoriesCatalog);
    }
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<CategoriesCatalog>> Post(CategoriesCatalog categoriesCatalog)
    {
        _unitOfWork.CategoriesCatalogs.Add(categoriesCatalog);
        await _unitOfWork.SaveAsync();
        return CreatedAtAction(nameof(Get), new { id = categoriesCatalog.Id }, categoriesCatalog);
    }
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Put(int id, [FromBody] CategoriesCatalog categoriesCatalog)
    {
        // Validación: objeto nulo
        if (categoriesCatalog == null)
            return BadRequest("El cuerpo de la solicitud está vacío.");

        // Validación: el ID de la URL debe coincidir con el del objeto (si viene con ID)
        if (id != categoriesCatalog.Id)
            return BadRequest("El ID de la URL no coincide con el ID del objeto enviado.");

        // Verificación: el recurso debe existir antes de actualizar
        var existingCategoriesCatalog = await _unitOfWork.CategoriesCatalogs.GetByIdAsync(id);
        if (existingCategoriesCatalog == null)
            return NotFound($"No se encontró el país con ID {id}.");

        // Actualización controlada de campos específicos
        existingCategoriesCatalog.Name = categoriesCatalog.Name; // Actualiza el texto de la pregunta recibido
        existingCategoriesCatalog.Price = categoriesCatalog.Price; // Actualiza el texto de la pregunta recibido
        // Puedes agregar más propiedades aquí según el modelo

        _unitOfWork.CategoriesCatalogs.Update(existingCategoriesCatalog);
        await _unitOfWork.SaveAsync();

        return Ok(existingCategoriesCatalog);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var categoriesCatalog = await _unitOfWork.CategoriesCatalogs.GetByIdAsync(id);
        if (categoriesCatalog == null)
            return NotFound();

        _unitOfWork.CategoriesCatalogs.Remove(categoriesCatalog);
        await _unitOfWork.SaveAsync();

        return NoContent();
    }
}
