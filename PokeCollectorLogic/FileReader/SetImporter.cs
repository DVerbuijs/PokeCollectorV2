using PokeCollectorData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PokeCollectorLogic.FileReader
{
   public class SetImporter
    {
        public List<Card> Import(string File)
        {
            List<Card> cards = new List<Card>();
            using (var reader = new StreamReader(File))
            {
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    Card card = new Card();
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    card.Number = Convert.ToInt32(values[0]);
                    card.Name = values[1];
                    CardType type;
                    Rarity rarity;
                    Set set;
                    Enum.TryParse(values[2], out type);
                    Enum.TryParse(values[3], out rarity);
                    Enum.TryParse(values[4], out set);
                    card.Type = type;
                    card.Rarity = rarity;
                    card.Set = set;
                    card.ReverseHolo = Convert.ToBoolean(values[5]);
                    cards.Add(card);

                }
                return cards;
            }
        }    
    }
}
