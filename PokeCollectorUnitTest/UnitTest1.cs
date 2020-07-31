using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokeCollectorV2;
using PokeCollectorData;
using PokeCollectorLogic;
using System.Collections.Generic;
using System.Configuration;
using System.Collections.Specialized;
using PokeCollectorLogic.FileReader;
using System.Windows.Documents;
using PokeCollectorLogic.Database;
using MongoDB.Bson;
using MongoDB.Driver;


namespace PokeCollectorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
     

        [TestMethod]
        public void TestSetImporter()
        {
            SetImporter importer = new SetImporter();
            List<Card> cards = new List<Card>();
            cards.AddRange(importer.Import(@"D:\denni\Documents\Pokemon\Gen2.csv"));
            Assert.IsNotNull(cards);
            Card test = new Card();
            test.Number = 1;
            test.Name = "Ampharos";
            test.Type = CardType.Lightning;
            test.Rarity = Rarity.RareHolo;
            test.Set = Set.NeoGenesis;
            test.ReverseHolo =false;
            test.Equals(cards[0]);
            Assert.AreEqual(test.Name, cards[0].Name);
            NoneChecker noneChecker = new NoneChecker();
            Assert.IsTrue(noneChecker.Check(cards));
           


        }
       
    }
}
