using Microsoft.AspNetCore.Mvc.Rendering;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace TrainingDiary.Models
{
    public class TrainingSession
    {
        public ObjectId Id { get; set; }
        public DateTime Date { get; set; }
        public string Exercise { get; set; }
        public double PerformanceData { get; set; }
               
    }
}
