using System;
using System.Collections.Generic;
using System.Text;

namespace PokeCollectorLogic.Database
{
    public class DBConnectionSet
    {
        public string Connection { get; set; }
        public string Database { get; set; }
        public string Table { get; set; }
        public string Filter { get; set; }
        public object FilterValue { get; set; }
    }
}
