using System;
using System.Collections.Generic;
namespace Domain.Entities;  
public class CategoriesCatalog : BaseEntity
{
    public int Id { get; set; } 
    public string? Name { get; set; } 
    public ICollection<CategoryOption> CategoryOptions { get; set; } = new List<CategoryOption>();
    public ICollection<OptionQuestion> OptionQuestions { get; set; } = new List<OptionQuestion>();
    public double Price { get; set; }
} 
