namespace Domain.Entities;  
    public class SubQuestion 
 { 
        public int Id { get; set; } 
        public DateTime CreatedAt { get; set; } 
        public int SubquestionId { get; set; } 
        public DateTime UpdatedAt { get; set; } 
        public string? SubquestionNumber { get; set; } 
        public string? CommentSubquestion { get; set; } 
        public string? Subquestiontext { get; set; } 
 } 
