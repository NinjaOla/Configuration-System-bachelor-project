namespace WorksoftConfigSystem.Models {
   using System;
   using System.Data.Entity;
   using System.ComponentModel.DataAnnotations.Schema;
   using System.Linq;

   public partial class Model1 : DbContext {
      public Model1()
          : base("name=Model1") {
      }

      public virtual DbSet<ConfigurableFunctions> ConfigurableFunctions { get; set; }
      public virtual DbSet<ConfigurationCategories> ConfigurationCategories { get; set; }
      public virtual DbSet<Settings> Settings { get; set; }

      /*
      protected override void OnModelCreating(DbModelBuilder modelBuilder) {
         modelBuilder.Entity<ConfigurationCategories>()
             .Property(e => e.ConfigurationCategoryDescription)
             .IsFixedLength();

         modelBuilder.Entity<ConfigurationCategories>()
             .HasMany(e => e.ConfigurableFunctions)
             .WithRequired(e => e.ConfigurationCategories)
             .WillCascadeOnDelete(false);

         modelBuilder.Entity<ConfigurationCategories>()
             .HasMany(e => e.Settings)
             .WithRequired(e => e.ConfigurationCategories)
             .WillCascadeOnDelete(false);

         modelBuilder.Entity<Settings>()
             .Property(e => e.Name)
             .IsUnicode(false);
      }
      */
   }
}
