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
          },
          new ExamQuestion
            {
                Number = 3,
                QuestionText = "What is the primary purpose of Entity Framework Core?",
                Choices = new Dictionary<string,string>
                {
                    {"A","To create HTML pages automatically"},
                    {"B","To replace the MVC Controller"},
                    {"C","To map objects in code to relational database data"},
                    {"D","To replace the C# compiler"}
                },
                CorrectLetter = "C - To map objects in code to relational database data"
            },
          new ExamQuestion
{
                Number = 4,
                QuestionText = "Which EF Core component is primarily responsible for communicating with the database?",
                Choices = new Dictionary<string,string>
                {
                    {"A","DbContext"},
                    {"B","DbSetView"},
                    {"C","ControllerContext"},
                    {"D","RazorContext"}
                },
                CorrectLetter = "A - DbContext"
            },




        };
    }
}


