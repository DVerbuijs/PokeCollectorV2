using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Collections.Specialized;

namespace PokeCollectorLogic
{
   public class Database
    {
        private string queuePath = ConfigurationManager.AppSettings.Get("Table").ToString();
        public string MyProperty { get {return queuePath; } }
    }
}
