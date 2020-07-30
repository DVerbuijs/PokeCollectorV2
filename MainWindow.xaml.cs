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
using System.Configuration;
using System.Collections.Specialized;

namespace PokeCollectorV2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           InitializeComponent();
           string queuePath = ConfigurationManager.AppSettings.Get("CS").ToString();
            Console.WriteLine(queuePath);

        }
        public static string message() { return "Hello PokeCollector V2"; }
    }
}
