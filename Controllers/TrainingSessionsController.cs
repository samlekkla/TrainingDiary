using Microsoft.AspNetCore.Mvc;
using TrainingDiary.Models;

namespace TrainingDiary.Controllers
{
    public class TrainingSessionsController : Controller
    {
        public async Task<IActionResult> Index()
        {
            Database db = new Database();
            var trainingsessions = await db.GetTrainingSessionsAsync(); 

            return View(trainingsessions);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(TrainingSession trainingSession)
        {
            Database db = new Database();

            await db.SaveTrainingSession(trainingSession);

            return Redirect("/TrainingSessions");
        }

        public async Task<IActionResult> Delete(string id)
        {
            Database db = new Database();
            var trainingsession = await db.GetTrainingSession(id);
            return View(trainingsession);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteTrainingSession(string id)
        {
            Database db = new Database();

            await db.DeleteTrainingSession(id);

            return Redirect("/TrainingSessions");
        }
               
    }
}
