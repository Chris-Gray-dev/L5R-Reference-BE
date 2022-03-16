using L5R_Reference_BE.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace L5R_Reference_BE.Services
{
    public class TechniqueService
    {

        private readonly IMongoCollection<Technique> _techniqueCollection;
        public TechniqueService(IOptions<DatabaseSettings> DatabaseSettings)
        {
            var client = new MongoClient(DatabaseSettings.Value.ConnectionString);
            var database = client.GetDatabase(DatabaseSettings.Value.DatabaseName);
            _techniqueCollection = database.GetCollection<Technique>(DatabaseSettings.Value.CollectionName);
        }

        public async Task<List<Technique>> GetAsync() =>
            await _techniqueCollection.Find(_ => true).ToListAsync();

        public async Task<Technique?> GetAsync(string id) =>
            await _techniqueCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
    }
}
