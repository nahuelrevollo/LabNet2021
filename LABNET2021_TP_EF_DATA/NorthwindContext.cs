namespace LABNET2021_TP_EF_DATA
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using LABNET2021_TP_EF_ENTITIES;

    public partial class NorthwindContext : DbContext
    {
        public NorthwindContext()
            : base("name=NorthwindConnection")
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);
        }
    }
}
