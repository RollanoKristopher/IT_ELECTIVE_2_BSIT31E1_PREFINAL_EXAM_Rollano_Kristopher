namespace ExamMVC.Models
{
    public class ExamQuestion
    {

        public int Number { get; set; }
        public string QuestionText { get; set; } = "";
        public string? CodeSnippet { get; set; }
        public Dictionary<string, string> Choices { get; set; } = new();
        public string CorrectLetter { get; set; } = "";
        public string CorrectAnswerText => Choices.TryGetValue(CorrectLetter, out var v) ? v : "";
    }
} 


 