using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
namespace PokeCollectorData
{
    public class Card
    {
        public ObjectId Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public CardType Type { get; set; }
        public Rarity Rarity { get; set; }
        public Set Set { get; set; }
        public bool ReverseHolo { get; set; }
        public override string ToString()
        {
            return base.ToString();
        }
        public override bool Equals(object obj)
        {
            Card toTest = (Card)obj;
            string thisValue = this.Number + this.Name + this.Type + this.Rarity + this.Set + this.ReverseHolo;
            string objValue = toTest.Number + toTest.Name + toTest.Type + toTest.Rarity + toTest.Set + toTest.ReverseHolo;
            if (thisValue.Equals(objValue))
            {
                return true;
            }
            else { return false; }
            //return base.Equals(obj);
        }
    }
}
