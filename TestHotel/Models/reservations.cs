namespace TestHotel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("testhotel.reservations")]
    public partial class reservations
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public reservations()
        {
            chambrereservees = new HashSet<chambrereservees>();
        }

        [Key]
        public int IdentifiantRes { get; set; }

        public DateTime DateReservation { get; set; }

        public DateTime DateDebutSejour { get; set; }

        public int NbNuits { get; set; }

        public int IdentifiantCli { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chambrereservees> chambrereservees { get; set; }

        public virtual clients clients { get; set; }
    }
}
