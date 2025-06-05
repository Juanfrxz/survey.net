namespace Domain.Entities;  
    public class SubQuestion : BaseEntity
 { 
        public int Id { get; set; } 
        public int SubQuestionId { get; set; } 
        public string? SubQuestionNumber { get; set; }
        public Question? Question { get; set; } 
        public string? CommentSubquestion { get; set; } 
        public string? SubQuestionText { get; set; } 
 } 
