using ExamMVC.Models;

namespace ExamMVC.Data
{
    public static class ExamData
    {
        public static List<ExamQuestion> Questions { get; } = new()
        {
            new ExamQuestion
            {
                Number = 1,
                QuestionText = "What is the main problem solved by using a database instead of an in-memory collection?",
                Choices = new Dictionary<string,string>
                {
                    {"A","It makes C# code shorter"},
                    {"B","It prevents the application from restarting"},
                    {"C","It allows data to persist after the application stops"},
                    {"D","It removes the need for MVC"}
                },
                CorrectLetter = "C"
            }
        };
    }
}