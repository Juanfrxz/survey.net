namespace Domain.Entities;  
    public class Question 
 { 
        public int Id { get; set; } 
        public int ChapterId { get; set; } 
        public DateTime CreatedAt { get; set; } 
        public DateTime UpdateAt { get; set; } 
        public string? QuestionNumber { get; set; } 
        public Chapter? Chapter { get; set; } 
        public string? ResponseType { get; set; } 
        public string? CommentQuestion { get; set; } 
        public string? QuestionText { get; set; } 
        public ICollection<SubQuestion> SubQuestions { get; set; } = new List<SubQuestion>();
        public ICollection<SumaryOption> SumaryOptions { get; set; } = new List<SumaryOption>();
 } 
