using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestHotel.Models;
using TestHotel.ViewModels;

namespace TestHotel.Services
{
    public class ChambresANettoyerService
    {
        #region Singleton 

        private static ChambresANettoyerService instance;
        public static ChambresANettoyerService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChambresANettoyerService();
                }
                return instance;
            }
        }

        private ChambresANettoyerService()
        {

        }
        #endregion

        public List<chambres> getChambresANettoyer(int numEtage)
        {
            List<chambres> chambres = new List<chambres>();
            using (HotelModel context = new HotelModel())
            {
                chambres = context.Database.SqlQuery<chambres>("CALL menageByEtage("+ numEtage +")").ToList();
                return chambres;
            }
        }

        internal void ChambreEstNettoyee(int numero)
        {
            using (HotelModel context = new HotelModel())
            {
                context.Database.ExecuteSqlCommand("UPDATE chambres SET DateDernierMenage = '"+ DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") +"' WHERE chambres.Numero = " + numero);
            }
        }
    }
}
