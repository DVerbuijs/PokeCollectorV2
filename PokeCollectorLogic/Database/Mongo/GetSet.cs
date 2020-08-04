using MongoDB.Bson;
using MongoDB.Driver;
using PokeCollectorData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PokeCollectorLogic.Database.Mongo
{
    public class GetSet
    {
        private MongoClient mongoClient = new MongoClient();
        private IMongoDatabase db;
        private bool reading;
        private List<Card> fulllist = new List<Card>();
        private DBConnectionSet ConnectionSet;

        public List<Card>Get(DBConnectionSet set)
        {
            this.ConnectionSet = set;
            Task taskGetSet = Task.Run(async () =>
            {
                await Fetch();

            });
            taskGetSet.Wait();
            return fulllist;

        }

        public async Task<List<Card>> Fetch()
        {
            
            mongoClient = new MongoClient(ConnectionSet.Connection);
            db = mongoClient.GetDatabase(ConnectionSet.Database);
            var col = db.GetCollection<Card>(ConnectionSet.Table);
            var filter = Builders<Card>.Filter.Eq(ConnectionSet.Filter, ConnectionSet.FilterValue);
            var list = await col.Find(filter).ToListAsync();
            fulllist.AddRange(list);
            return fulllist;
        }
  
    }
}
