using PokeCollectorData;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokeCollectorLogic.FileReader
{
   public class NoneChecker
    {
        public bool Check(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                if (card.Rarity == Rarity.NONE || card.Set == Set.NONE || card.Type == CardType.NONE)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
