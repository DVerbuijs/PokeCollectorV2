using MongoDB.Driver;
using PokeCollectorData;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokeCollectorLogic.Database.Mongo
{
   public class WriteSet
    {
        private MongoClient mongoClient = new MongoClient();
        private IMongoDatabase db;
        private List<Card> cards;
        public bool Write(List<Card> cards)
        {
            string connectionString = "mongodb://TCGUser:yp7KN8Du3BmDyTpu@192.168.2.9:27017/TCG";
            mongoClient = new MongoClient(connectionString);
            db = mongoClient.GetDatabase("TCG");
            this.cards = cards;
            WriteToDB();
            return true;
        }

        private async void WriteToDB()
        {
            var collection = db.GetCollection<Card>("PokemonSet");
            await collection.InsertManyAsync(cards);
        }
    }
}
