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
                CorrectLetter = "C - It allows data to persist after the application stops"
            },
          new ExamQuestion
          {
            Number = 2,
            QuestionText = "Which approach is being used when an existing database is used to generate EF Core entity classes?",
            Choices = new Dictionary<string,string>
            {
                {"A","Code-First"},
                {"B","Database-First"},
                {"C","Model-First"},
                {"D","Controller-First"}
            },
            CorrectLetter = "B - Database-First"
          }
        };
    }
}


