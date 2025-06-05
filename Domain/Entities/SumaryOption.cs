namespace Domain.Entities;  
    public class SumaryOption : BaseEntity
 { 
        public int Id { get; set; } 
        public int IdSurvey { get; set; } 
        public string? CodeNumber { get; set; } 
        public int Idquestion { get; set; } 
        public string? Valuerta { get; set; } 
        public Survey? Survey { get; set; } 
        public Question? Question { get; set; } 
 } 
