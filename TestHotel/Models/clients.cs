namespace TestHotel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("clients")]
    public partial class clients
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public clients()
        {
            reservations = new HashSet<reservations>();
        }

        [Key]
        public int IdentifiantCli { get; set; }

        [Required]
        [StringLength(25)]
        public string Nom { get; set; }

        [Required]
        [StringLength(25)]
        public string Prenom { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(10)]
        public string Telephone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reservations> reservations { get; set; }
    }
}
