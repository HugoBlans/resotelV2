namespace TestHotel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("testhotel.chambres")]
    public partial class chambres
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public chambres()
        {
            chambrereservees = new HashSet<chambrereservees>();
            prix = new HashSet<prix>();
        }

        [Key]
        public int Numero { get; set; }

        public int numEtage { get; set; }

        public int NbLit { get; set; }

        public bool LitEnfant { get; set; }

        public bool LitDouble { get; set; }

        public DateTime DateDernierMenage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chambrereservees> chambrereservees { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prix> prix { get; set; }
    }
}
