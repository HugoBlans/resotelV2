using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Navigation;
using TestHotel.Views;

namespace TestHotel.ViewModels
{
    class MainVM : BaseViewModel
    {
        private ObservableCollection<UserControl> _listPages;

        public ObservableCollection<UserControl> ListPages
        {
            get { return _listPages; }
            set { 
                _listPages = value;
                NotifyPropertyChanged();
            }
        }

        private UserControl _currentPage;

        public UserControl CurrentPage
        {
            get { return _currentPage; }
            set 
            { 
                _currentPage = value;
                NotifyPropertyChanged();
            }
        }

        public MainVM()
        {
            ListPages = new ObservableCollection<UserControl>();
            Accueil acc = new Accueil();
            ListPages.Add(acc);
            CurrentPage = acc;
        }

        private RelayCommand _navigation;

        public RelayCommand Navigation
        {
            get 
            {
                if (_navigation == null)
                {
                    _navigation = new RelayCommand(goAccueil);
                }
                return _navigation; 
            }
        }

        private void goAccueil(object dest)
        {
            UserControl destUC = null;
            switch ((string)dest)
            {
                case "accueil":
                    destUC = ListPages.FirstOrDefault(x => x is Accueil);
                    if (destUC == null) destUC = new Accueil();
                    break;
                case "clients":
                    destUC = ListPages.FirstOrDefault(x => x is Clients);
                    if (destUC == null) destUC = new Clients();
                    break;
                case "reservations":
                    destUC = ListPages.FirstOrDefault(x => x is Reservations);
                    if (destUC == null) destUC = new Reservations();
                    break;
                case "repas":
                    destUC = ListPages.FirstOrDefault(x => x is Repas);
                    if (destUC == null) destUC = new Repas();
                    break;
                case "menages":
                    destUC = ListPages.FirstOrDefault(x => x is Menages);
                    if (destUC == null) destUC = new Menages();
                    break;
            }

            CurrentPage = destUC;
        }
    }
}
