namespace Domain.Entities;  
    public class SubQuestion 
 { 
        public int Id { get; set; } 
        public DateTime CreatedAt { get; set; } 
        public int SubQuestionId { get; set; } 
        public DateTime UpdatedAt { get; set; } 
        public string? SubQuestionNumber { get; set; }
        public Question? Question { get; set; } 
        public string? CommentSubquestion { get; set; } 
        public string? SubQuestionText { get; set; } 
 } 
