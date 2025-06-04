namespace Domain.Entities;  
    public class CategoriesCatalog 
 { 
        public int Id { get; set; } 
        public DateTime CreatedAt { get; set; } 
        public DateTime UpdatedAt { get; set; } 
        public string? Name { get; set; } 
        public ICollection<CategoryOption> CategoryOptions { get; set; } = new List<CategoryOption>();
        public ICollection<OptionQuestion> OptionQuestions { get; set; } = new List<OptionQuestion>();
 } 
