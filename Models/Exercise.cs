using MongoDB.Bson;

namespace TrainingDiary.Models
{
    public class Exercise
    {
        public ObjectId Id { get; set; }
        public string Name {  get; set; }
        public string Description { get; set; }

    }
}
