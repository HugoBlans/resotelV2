namespace TestHotel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("testhotel.options")]
    public partial class options
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public options()
        {
            demandeoptions = new HashSet<demandeoptions>();
        }

        [Key]
        public int NumOption { get; set; }

        [Required]
        [StringLength(50)]
        public string Designation { get; set; }

        public decimal Prix { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<demandeoptions> demandeoptions { get; set; }
    }
}
