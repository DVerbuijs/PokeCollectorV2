using PokeCollectorData;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokeCollectorLogic.Database
{
   public interface IDatabase
    {
        bool WriteSetToDB();
        bool SetTable(string table);
        List<Card> ReadSetFromDB(Set set);
        bool UpdateCollectedCard(Card card);

    }
}
