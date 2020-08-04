using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;


namespace PokeCollectorData
{
    public class OldCard
    {
        public ObjectId Id { get; set; }
        public String CardNumber { get; set; }
        public String CardName { get; set; }
        public String Serie { get; set; }
        public Boolean Collected { get; set; }
        public Boolean CollectedRevers { get; set; }
        public String Type { get; set; }
        public String Rarity { get; set; }

        public override string ToString()
        {
            return CardNumber + CardName;
        }

        public string ToCSV()
        {
            return CardNumber + ";" + CardName + ";" + Serie + ";" + Collected + ";" + CollectedRevers + ";" + Type + ";" + Rarity;
        }
    }
}
