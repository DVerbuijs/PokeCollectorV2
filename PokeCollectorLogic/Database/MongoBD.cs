using PokeCollectorData;
using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;

namespace PokeCollectorLogic.Database
{
    public class MongoBD : IDatabase
    {
        private MongoClient mongoClient;
        private IMongoDatabase db;
        public MongoBD(String connection)
        {
            mongoClient = new MongoClient(connection);
        }

        public List<Card> ReadSetFromDB(Set set)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCollectedCard(Card card)
        {
            throw new NotImplementedException();
        }

        public bool WriteSetToDB()
        {
            throw new NotImplementedException();
        }

        public bool SetTable(string table)
        {
            try
            {
                db = mongoClient.GetDatabase(table);
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Table not found");
            }
        }
    }
}
