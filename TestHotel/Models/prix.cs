namespace TestHotel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("testhotel.prix")]
    public partial class prix
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public prix()
        {
            chambres = new HashSet<chambres>();
        }

        [Key]
        public int idPrix { get; set; }

        [Column("prix")]
        public decimal prix1 { get; set; }

        public int NbNuit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chambres> chambres { get; set; }
    }
}
