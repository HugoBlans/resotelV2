using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHotel.Models
{
    public class chambreANettoyer
    {
        public int Numero;
        public int Etage;

        public chambreANettoyer(int num, int etage)
        {
            this.Etage = etage;
            this.Numero = num;
        }
    }
}
