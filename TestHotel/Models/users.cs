namespace TestHotel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("testhotel.users")]
    public partial class users
    {
        [Key]
        [StringLength(80)]
        public string Identifiant { get; set; }

        [Required]
        [StringLength(80)]
        public string Role { get; set; }

        [StringLength(80)]
        public string Email { get; set; }
    }
}
