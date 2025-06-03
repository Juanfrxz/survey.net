namespace Domain.Entities;  
    public class OptionQuestion 
 { 
        public int Id { get; set; } 
        public DateTime CreatedAt { get; set; } 
        public int OptionId { get; set; } 
        public int OptioncatalogId { get; set; } 
        public int OptionquestionId { get; set; } 
        public int SubquestionId { get; set; } 
        public DateTime UpdateAt { get; set; } 
        public string? CommentOptionres { get; set; } 
        public string? Numberoption { get; set; } 
 } 
