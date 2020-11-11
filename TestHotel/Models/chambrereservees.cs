namespace TestHotel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("chambrereservees")]
    public partial class chambrereservees
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public chambrereservees()
        {
            demandeoptions = new HashSet<demandeoptions>();
            repas = new HashSet<repas>();
        }

        public int Id { get; set; }

        public int NbPersonne { get; set; }

        public int IdentifiantRes { get; set; }

        public int Numero { get; set; }

        public virtual chambres chambres { get; set; }

        public virtual reservations reservations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<demandeoptions> demandeoptions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<repas> repas { get; set; }
    }
}
