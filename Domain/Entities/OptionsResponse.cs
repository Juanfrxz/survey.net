namespace Domain.Entities;  
    public class OptionsResponse 
 { 
        public int Id { get; set; } 
        public DateTime CreatedAt { get; set; } 
        public DateTime UpdatedAt { get; set; } 
        public string? OptionText { get; set; } 
        public ICollection<CategoryOption> CategoryOptions { get; set; } = new List<CategoryOption>(); 
 } 
