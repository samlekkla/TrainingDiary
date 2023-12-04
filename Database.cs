using MongoDB.Bson;
using MongoDB.Driver;
using System;
using TrainingDiary.Models;

namespace TrainingDiary
{
    public class Database
    {
        MongoClient dbClient = new MongoClient();

        private IMongoDatabase GetDb()
        {
            return dbClient.GetDatabase("ExerciseDiarysDB");
        }

        public async Task<List<Exercise>> GetExercisesAsync()
        {
            return await GetDb().GetCollection<Exercise>("Exercises")
                .Find(b => true)
                .ToListAsync();
        }

        public async Task SaveExercise(Exercise exercise)
        {
            await GetDb().GetCollection<Exercise>("Exercises")
                .InsertOneAsync(exercise);
        }

        public async Task<Exercise> GetExercise(string id)
        {
            ObjectId _id = new ObjectId(id);

            var exercise = await GetDb().GetCollection<Exercise>("Exercises")
                .Find(e => e.Id == _id)
                .SingleOrDefaultAsync();

            return exercise;
        }

        public async Task DeleteExcercise(string id)
        {
            ObjectId _id = new ObjectId(id);

            await GetDb().GetCollection<Exercise>("Exercises")
                .DeleteOneAsync(e => e.Id == _id);
        }
        
        // TrainingSessions model
        public async Task<List<TrainingSession>> GetTrainingSessionsAsync()
        {
            return await GetDb().GetCollection<TrainingSession>("TrainingSessions")
                .Find(t => true)
                .ToListAsync();
        }

        public async Task SaveTrainingSession(TrainingSession trainingSession)
        {
            await GetDb().GetCollection<TrainingSession>("TrainingSessions")
                .InsertOneAsync(trainingSession);
        }

        public async Task<TrainingSession> GetTrainingSession(string id)
        {
            ObjectId _id = new ObjectId(id);

            var trainingsession = await GetDb().GetCollection<TrainingSession>("TrainingSessions")
                .Find(t => t.Id == _id)
                .SingleOrDefaultAsync();

            return trainingsession;
        }

        public async Task DeleteTrainingSession(string id)
        {
            ObjectId _id = new ObjectId(id);

            await GetDb().GetCollection<TrainingSession>("TrainingSessions")
                .DeleteOneAsync(t => t.Id == _id);
        }

        
    }

}
