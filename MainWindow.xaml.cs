using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PokeCollectorLogic;
using PokeCollectorLogic.Database;
using PokeCollectorLogic.Database.Mongo;
using System.Configuration;
using PokeCollectorData;
using System.Collections.Specialized;
using MongoDB.Driver;
using PokeCollectorLogic.FileReader;

namespace PokeCollectorV2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MongoClient mongoClient = new MongoClient();
        private IMongoDatabase db;
        private List<Card> fulllist = new List<Card>();
        public MainWindow()
        {
           InitializeComponent();

            DBConnectionSet connectionSet = new DBConnectionSet();
            connectionSet.Connection = ConfigurationManager.AppSettings.Get("CS").ToString();
            connectionSet.Database = ConfigurationManager.AppSettings.Get("DB").ToString();
            connectionSet.Table = ConfigurationManager.AppSettings.Get("Table").ToString();
            connectionSet.Filter = "Set";
            connectionSet.FilterValue = Set.NeoGenesis;
            

            GetSet getSet = new GetSet();
            fulllist.AddRange(getSet.Get(connectionSet));

            int count = fulllist.Count;
            Console.WriteLine(count);

        }
      
        public static string message() { return "Hello PokeCollector V2"; }
    }
}
