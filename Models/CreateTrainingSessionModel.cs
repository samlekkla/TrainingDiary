using Microsoft.AspNetCore.Mvc.Rendering;
using MongoDB.Bson;

namespace TrainingDiary.Models
{
    public class CreateTrainingSessionModel
    {
        public ObjectId Id { get; set; }
        public DateTime Date { get; set; }
        public IEnumerable<SelectListItem> Sessions { get; set; }
        public string PerformanceData { get; set; }
        public IEnumerable<SelectListItem> Exercises { get; internal set; }
    }
}
