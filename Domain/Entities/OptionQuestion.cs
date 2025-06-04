namespace Domain.Entities;  
    public class OptionQuestion 
 { 
        public int Id { get; set; } 
        public DateTime CreatedAt { get; set; } 
        public int OptionId { get; set; } 
        public int OptioncatalogId { get; set; } 
        public CategoriesCatalog? CategoriesCatalog { get; set; } 
        public int OptionquestionId { get; set; } 
        public int SubquestionId { get; set; } 
        public DateTime UpdateAt { get; set; } 
        public string? CommentOptionres { get; set; } 
        public string? Numberoption { get; set; } 
        public Question? Question { get; set; } 
        public SubQuestion? SubQuestion { get; set; } 
        public OptionsResponse? Option { get; set; } 
 } 
