using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestHotel.Models;
using TestHotel.Services;

namespace TestHotel.ViewModels
{
    public class ChambreANettoyerViewModel : BaseViewModel
    {
        private chambres _chambreANet;

        public chambres ChambreANet
        {
            get { return _chambreANet; }
            set {
                _chambreANet = value;
                NotifyPropertyChanged();
            }
        }

        public int Numero
        {
            get
            {
                return ChambreANet.Numero;
            }
        }

        public int NumeroEtage
        {
            get
            {
                return ChambreANet.numEtage;
            }
        }



        public ChambresANettoyerService Srv { get; set; }

        public ChambreANettoyerViewModel(chambres cn, ChambresANettoyerService srv)
        {
            Srv = srv;
            ChambreANet = cn;
        }


        public event EventHandler ChambreNettoyee;

        private RelayCommand _estNettoyee;

        public RelayCommand EstNettoyee
        {
            get
            {
                if (_estNettoyee == null)
                {
                    _estNettoyee = new RelayCommand(chambreUpdateNettoyage);
                }
                return _estNettoyee;
            }
        }

        private void chambreUpdateNettoyage()
        {
            Srv.ChambreEstNettoyee(ChambreANet.Numero);
            ChambreNettoyee?.Invoke(this, EventArgs.Empty);
        }
    }
}
