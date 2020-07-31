using System;
using System.Collections.Generic;
using System.Text;

namespace PokeCollectorLogic.Database
{
    public class DBfactory
    {

        public IDatabase CreateDB(string connection)
        {
            IDatabase database;
            if(connection.StartsWith("mongodb"))
            {
                database = new MongoBD(connection);
                return database;
            }
            else
            {
                return null;
            }
        }
    }
}
