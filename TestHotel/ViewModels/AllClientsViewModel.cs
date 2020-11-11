using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using TestHotel.Models;
using TestHotel.Services;

namespace TestHotel.ViewModels
{
    class AllClientsViewModel : BaseViewModel
    {
        private ObservableCollection<ClientViewModel> _listClients;

        public ObservableCollection<ClientViewModel> ListClients
        {
            get { return _listClients; }
            set { _listClients = value; }
        }

        private clients _currentClient;

        public ClientViewModel CurrentClient
        {
            get {  return observer.CurrentItem as ClientViewModel; }
        }

        public ClientsService Srv { get; set; }

        private readonly ICollectionView observer;

        public AllClientsViewModel()
        {
            Srv = new ClientsService();
            ListClients = new ObservableCollection<ClientViewModel>();
            UpdateListClients();
            observer = CollectionViewSource.GetDefaultView(ListClients);
            observer.CurrentChanged += CurrentClientChanged;
            observer.MoveCurrentToFirst();
        }

        private void CurrentClientChanged(object sender, EventArgs e)
        {
            NotifyPropertyChanged("CurrentClient");
        }

        private void UpdateListClients()
        {
            List<clients> AllClients = Srv.GetAllClients();

            foreach (clients cli in AllClients)
            {
                ClientViewModel newCli = new ClientViewModel(Srv, cli);
                ListClients.Add(newCli);
            }
        }
    }
}
