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
                new ExamQuestion
            {
                Number = 5,
                QuestionText = "What does the following command primarily do?",
                CodeSnippet = "dotnet ef dbcontext scaffold \"ConnectionString\" Microsoft.EntityFrameworkCore.SqlServer -o Models",
                Choices = new Dictionary<string,string>
                {
                    {"A","Deletes the database"},
                    {"B","Creates a new MVC project"},
                    {"C","Generates EF Core models and a DbContext from an existing database"},
                    {"D","Starts the MVC application"}
                },
                CorrectLetter = "C - Generates EF Core models and a DbContext from an existing database"
            },

                new ExamQuestion
            {
                Number = 6,
                QuestionText = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?",
                Choices = new Dictionary<string,string>
                {
                    {"A","Program.cs only"},
                    {"B","appsettings.json"},
                    {"C","Index.cshtml"},
                    {"D","Student.cs"}
                },
                CorrectLetter = "B - appsettings.json"
            },
                new ExamQuestion
            {
                Number = 7,
                QuestionText = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?",
                Choices = new Dictionary<string,string>
                {
                    {"A","One-to-One"},
                    {"B","One-to-Many"},
                    {"C","Many-to-Many"},
                    {"D","Many-to-One only"}
                },
                CorrectLetter = "B - One-to-Many"
            },
                new ExamQuestion
                {
                    Number = 8,
                    QuestionText = "In the following example, what is SectionId?",
                    CodeSnippet = "public int SectionId { get; set; }\npublic Section Section { get; set; }",
                    Choices = new Dictionary<string,string>
                    {
                        {"A","Primary key of Student"},
                        {"B","Foreign key referencing Section"},
                        {"C","Navigation property"},
                        {"D","Database connection string"}
                    },
                    CorrectLetter = "B - Foreign key referencing Section"
                },







          };
    }
}


