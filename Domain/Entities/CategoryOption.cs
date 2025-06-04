namespace Domain.Entities;  
    public class CategoryOption 
 { 
        public int Id { get; set; } 
        public int CatalogoptionsId { get; set; } 
        public int CategoriesOptionsId { get; set; } 
        public DateTime CreatedAt { get; set; } 
        public DateTime UpdatedAt { get; set; } 
        public CategoriesCatalog? CategoriesCatalog { get; set; } 
        public OptionsResponse? OptionsResponse { get; set; } 
 } 
