namespace Domain.Entities;  
    public class Chapter : BaseEntity
 { 
        public int Id { get; set; } 
        public int SurveyId { get; set; } 
        public string? ComponentHtml { get; set; } 
        public string? ComponentReact { get; set; } 
        public string? ChapterNumber { get; set; } 
        public string? ChapterTitle { get; set; } 
        public Survey? Survey { get; set; } 
        public ICollection<Question> Questions { get; set; } = new List<Question>();
 } 
