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
using TestHotel.Services;
using TestHotel.ViewModels;

namespace TestHotel.Views
{
    /// <summary>
    /// Logique d'interaction pour Menages.xaml
    /// </summary>
    public partial class Menages : UserControl
    {

        public AllChambresANettoyer AllCaNVM { get; set; }
        public Menages()
        {
            AllCaNVM = new AllChambresANettoyer(ChambresANettoyerService.Instance);
            DataContext = AllCaNVM;
            InitializeComponent();
        }
    }
}
