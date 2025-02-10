using System.Diagnostics;
using DBTargetQuiz.Models;
using DBTargetQuiz.Models.DTOs;
using DBTargetQuiz.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DBTargetQuiz.Controllers
{
    public class QuizController : Controller
    {
        private readonly IQuestionService _questionService;
        private readonly IQuizService _quizService;
        private readonly IQuizAnswerService _quizAnswerService;
        private readonly ICandidateService _candidateService;

        public QuizController(
            IQuestionService questionService,
            IQuizService quizService,
            IQuizAnswerService quizAnswerService,
            ICandidateService candidateService)
        {
            _questionService = questionService;
            _quizService = quizService;
            _quizAnswerService = quizAnswerService;
            _candidateService = candidateService;
        }

        public async Task<IActionResult> Index()
        {
            var questions = await _questionService.GetAllWithAnswersAsync();

            if (questions == null || !questions.Any())
            {
                ModelState.AddModelError("", "No hay preguntas disponibles.");
                return View(new List<QuizViewModel>());
            }

            var viewModel = questions.Select(q => new QuizViewModel
            {
                QuestionId = q.QuestionId,
                QuestionDescription = q.Description,
                QuestionPicture = q.Picture,
                Answers = q.Answers?.ToList() ?? new List<Answer>()
            }).ToList();

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> SubmitQuiz(List<UserAnswerViewModel> userAnswers)
        {
            if (userAnswers?.Any() != true)
            {
                ModelState.AddModelError("", "Debes responder todas las preguntas.");
                return RedirectToAction("Index");
            }

            var quiz = new Quiz
            {
                Code = $"QZ{Guid.NewGuid().ToString("N")[..7]}",
                Date = DateTime.Now,
                Status = 0
            };

            await _quizService.AddAsync(quiz);

            var quizAnswers = userAnswers
                .Where(a => a.SelectedAnswerId > 0)
                .Select(a => new QuizAnswer
                {
                    QuizId = quiz.QuizId,
                    QuestionId = a.QuestionId,
                    AnswerId = a.SelectedAnswerId
                })
                .ToList();

            if (quizAnswers.Any())
            {
                await _quizAnswerService.AddRangeAsync(quizAnswers);
            }

            await _quizService.CalculateMatchingCandidates(quiz.QuizId);
            var updatedQuiz = await _quizService.GetByIdAsync(quiz.QuizId);

            if (updatedQuiz?.Candidate1Id.HasValue == true)
            {
                var candidate = await _candidateService.GetByIdAsync(updatedQuiz.Candidate1Id.Value);
                return View("Result", candidate);
            }

            return View("Result", null);
        }

        public IActionResult Result()
        {
            return View();
        }
    }
}
