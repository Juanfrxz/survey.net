namespace Domain.Entities;  
    public class OptionsResponse : BaseEntity
 { 
        public int Id { get; set; } 
        public string? OptionText { get; set; } 
        public ICollection<CategoryOption> CategoryOptions { get; set; } = new List<CategoryOption>(); 
 } 
