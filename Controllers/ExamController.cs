using ExamMVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace ExamMVC.Controllers
{
    public class ExamController : Controller
    {

        public IActionResult Details(int id)
        {
            var question = ExamData.Questions.FirstOrDefault(q => q.Number == id);
            if (question == null)
            {
                return NotFound();
            }
            return View(question);
        }
    }
}
