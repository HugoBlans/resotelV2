﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestHotel.Models;
using TestHotel.Services;

namespace TestHotel.ViewModels
{
    class ClientViewModel : BaseViewModel
    {
        public ClientsService Srv { get; set; }
        private clients _client;

        public clients Client
        {
            get { return _client; }
            set 
            { 
                _client = value;
                NotifyPropertyChanged();
            }
        }

        public int ID
        {
            get { return Client.IdentifiantCli; }
            set 
            {
                Client.IdentifiantCli = value;
                NotifyPropertyChanged();
            }
        }

        public string Nom
        {
            get { return Client.Nom; }
            set
            {
                Client.Nom = value;
                NotifyPropertyChanged();
            }
        }

        public string Prenom
        {
            get { return Client.Prenom; }
            set 
            { 
                Client.Prenom = value; 
                NotifyPropertyChanged();
            }
        }

        public string Email
        {
            get { return Client.Email; }
            set 
            { 
                Client.Email = value;
                NotifyPropertyChanged();
            }
        }

        public string Telephone
        {
            get { return Client.Telephone; }
            set 
            {
                Client.Telephone = value;
                NotifyPropertyChanged();
            }
        }

        public event EventHandler ClientDeleted;

        private RelayCommand _delete;

        public RelayCommand Delete
        {
            get
            {
                if (_delete == null)
                {
                    _delete = new RelayCommand(DeleteExcecute);
                }
                return _delete;
            }
        }

        private void DeleteExcecute()
        {
            Srv.RemoveClient(Client.IdentifiantCli);
            ClientDeleted?.Invoke(this, EventArgs.Empty);
        }


        private RelayCommand _update;

        public RelayCommand Update
        {
            get
            {
                if (_delete == null)
                {
                    _delete = new RelayCommand(UpdateExcecute);
                }
                return _delete;
            }
        }

        private void UpdateExcecute()
        {
            Srv.UpdateClient(Client);
        }

        public ClientViewModel(ClientsService srvCli, clients cli)
        {
            Srv = srvCli;
            Client = cli;
        }
    }
}
