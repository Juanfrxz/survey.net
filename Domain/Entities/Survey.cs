namespace Domain.Entities;  
    public class Survey : BaseEntity
 { 
        public int Id { get; set; } 
        public string? ComponentHtml { get; set; } 
        public string? ComponentReact { get; set; } 
        public string? Description { get; set; } 
        public string? Instruction { get; set; } 
        public string? Name { get; set; } 
        public ICollection<Chapter> Chapters { get; set; } = new List<Chapter>();
        public ICollection<SumaryOption> SumaryOptions { get; set; } = new List<SumaryOption>();
 } 
