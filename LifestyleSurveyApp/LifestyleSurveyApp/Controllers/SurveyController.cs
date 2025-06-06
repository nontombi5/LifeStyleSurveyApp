using LifestyleSurveyApp.Data;
using LifestyleSurveyApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LifestyleSurveyApp.Controllers
{
    public class SurveyController : Controller
    {
        private readonly AppDbContext _context;

        public SurveyController(AppDbContext context)
        {
            _context = context;
        }

        
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Survey survey)
        {
            var age = survey.Age;
            if (age < 5 || age > 120)
            {
                ModelState.AddModelError("DateOfBirth", "Age must be between 5 and 120 years.");
            }

            if (ModelState.IsValid)
            {
                _context.Add(survey);
                _context.SaveChanges();
                TempData["Success"] = "Survey submitted successfully!";
                return RedirectToAction(nameof(Create));
            }

            return View(survey);
        }


        public IActionResult Results()
        {
            var surveys = _context.Survey.ToList();

            if (!surveys.Any()) 
            {
                ViewBag.Message = "No Surveys Available";
                return View();
            }

            var age = surveys.Select(s => s.Age).ToList();

            var results = new
            {
                TotalNoSurvey = surveys.Count,
                ParticipatedAverageAge = age.Average(),
                OldestParticipant = age.Max(),
                YoungestParticipant = age.Min(),
                PizzaPercentage = Math.Round((double)surveys.Count(s => s.Pizza) * 100 / surveys.Count, 1),
                PastaPercentage = Math.Round((double)surveys.Count(s => s.Pasta) * 100 / surveys.Count, 1),
                PapaAndWorsePercentage = Math.Round((double)surveys.Count(s => s.PapAndWors) * 100 / surveys.Count, 1),
                OtherPercentage = Math.Round((double)surveys.Count(s => s.Other) * 100 / surveys.Count, 1),

                AverageEatOut = Math.Round(surveys.Average(s => s.EatOut), 1),
                AverageWatchMovies = Math.Round(surveys.Average(s => s.WatchMovies), 1),
                AvarageWatchTV = Math.Round(surveys.Average(s => s.WatchTV), 1),
                AvarageListenToRadio = Math.Round(surveys.Average(s => s.ListenToRadio), 1)
            };

            return View(results);
        }

    }
}
