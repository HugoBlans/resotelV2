namespace TestHotel.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HotelModel : DbContext
    {
        public HotelModel()
            : base("name=HotelModel")
        {
        }

        public virtual DbSet<chambrereservees> chambrereservees { get; set; }
        public virtual DbSet<chambres> chambres { get; set; }
        public virtual DbSet<clients> clients { get; set; }
        public virtual DbSet<demandeoptions> demandeoptions { get; set; }
        public virtual DbSet<options> options { get; set; }
        public virtual DbSet<prix> prix { get; set; }
        public virtual DbSet<repas> repas { get; set; }
        public virtual DbSet<reservations> reservations { get; set; }
        public virtual DbSet<users> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<chambrereservees>()
                .HasMany(e => e.demandeoptions)
                .WithRequired(e => e.chambrereservees)
                .HasForeignKey(e => e.IdChambreReservee);

            modelBuilder.Entity<chambrereservees>()
                .HasMany(e => e.repas)
                .WithRequired(e => e.chambrereservees)
                .HasForeignKey(e => e.IdChambreReservee);

            modelBuilder.Entity<chambres>()
                .HasMany(e => e.prix)
                .WithMany(e => e.chambres)
                .Map(m => m.ToTable("prixchambres", "testhotel").MapLeftKey("Chambre_Numero").MapRightKey("Prix_idPrix"));

            modelBuilder.Entity<clients>()
                .Property(e => e.Nom)
                .IsUnicode(false);

            modelBuilder.Entity<clients>()
                .Property(e => e.Prenom)
                .IsUnicode(false);

            modelBuilder.Entity<clients>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<clients>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<options>()
                .Property(e => e.Designation)
                .IsUnicode(false);

            modelBuilder.Entity<options>()
                .HasMany(e => e.demandeoptions)
                .WithRequired(e => e.options)
                .HasForeignKey(e => e.IdOption);

            modelBuilder.Entity<users>()
                .Property(e => e.Identifiant)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.Email)
                .IsUnicode(false);
        }
    }
}
