namespace Domain.Entities;  
    public class Survey 
 { 
        public int Id { get; set; } 
        public DateTime CreatedAt { get; set; } 
        public DateTime UpdatedAt { get; set; } 
        public string? ComponentHtml { get; set; } 
        public string? ComponentReact { get; set; } 
        public string? Description { get; set; } 
        public string? Instruction { get; set; } 
        public string? Name { get; set; } 
 } 
