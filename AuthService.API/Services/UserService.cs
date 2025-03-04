using System;
using AuthService.API.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace AuthService.API.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> _users;

        public UserService(IConfiguration config)
        {
            var settings = MongoClientSettings.FromConnectionString(config["MongoDB:ConnectionString"]);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var database = client.GetDatabase(config["MongoDB:DatabaseName"]);
            _users = database.GetCollection<User>(config["MongoDB:UsersCollection"]);
        }

        public async Task<User> GetUserByUsernameAsync(string username)
        {
            return await _users.Find(u => u.Username == username && u.IsActive==true).FirstOrDefaultAsync();
        }

        public async Task CreateUserAsync(User user)
        {
            await _users.InsertOneAsync(user);
        }
    }
}

