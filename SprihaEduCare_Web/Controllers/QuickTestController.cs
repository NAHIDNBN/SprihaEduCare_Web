using Microsoft.AspNetCore.Mvc;
using SprihaEduCare_Web.DataAccess;
using SprihaEduCare_Web.Models;

namespace SprihaEduCare_Web.Controllers
{
    public class QuickTestController : Controller
    {
        private readonly QuickTestDbContext _context;

        public QuickTestController(QuickTestDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var parts = new[] { "Math", "English", "General Knowdledge", "Science", "SocialScience" };
            var selectedQuestions = new List<QuickTest>();

            //foreach (var part in parts)
            //{
            //    var questions = _context.QuickTests.Where(q => q.Part == part).OrderBy(q => Guid.NewGuid()).Take(5).ToList();

            //    selectedQuestions.AddRange(questions);
            //}

            return View();
        }

        //[HttpPost]
        //public IActionResult SubmitAnswers(IFormCollection form)
        //{
        //    int score = 0;
        //    var submittedAnswers = new List<(int QuestionId, string SelectedAnswer, string CorrectAnswer)>();

        //    // Loop through each submitted field
        //    foreach (var key in form.Keys)
        //    {
        //        if (key.StartsWith("answer_"))
        //        {
        //            // Extract question ID from key
        //            var idPart = key.Replace("answer_", "");
        //            if (int.TryParse(idPart, out int questionId))
        //            {
        //                string selectedAnswer = form[key];
        //                var question = _context.QuickTests.FirstOrDefault(q => q.Id == questionId);
        //                if (question != null)
        //                {
        //                    bool isCorrect = selectedAnswer == question.CorrectAnswer;
        //                    if (isCorrect)
        //                    {
        //                        score++;
        //                    }

        //                    submittedAnswers.Add((questionId, selectedAnswer, question.CorrectAnswer));
        //                }
        //            }
        //        }
        //    }

        //    ViewBag.Score = score;
        //    ViewBag.TotalQuestions = submittedAnswers.Count;
        //    return View("Answer", submittedAnswers); // Pass data to Results.cshtml
        //}
    }
}
