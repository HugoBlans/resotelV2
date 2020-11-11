namespace TestHotel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("testhotel.repas")]
    public partial class repas
    {
        public int Id { get; set; }

        public bool EstPetitDejeuner { get; set; }

        public DateTime DateRepas { get; set; }

        public int IdChambreReservee { get; set; }

        public virtual chambrereservees chambrereservees { get; set; }
    }
}
