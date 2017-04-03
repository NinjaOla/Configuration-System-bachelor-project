using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WorksoftConfigSystem.Models;

namespace WorksoftConfigSystem.DataLayer {
   public class DatabaseContext : DbContext {


      public DatabaseContext()
         : base("name=azureWorksoftString") {
         ConfigurableFunctionsSet = Set<ConfigurableFunctions>();
         ConfigurationCategoriesSet = Set<ConfigurationCategories>();
         SettingsSet = Set<Settings>();
      }

      public virtual DbSet<ConfigurableFunctions> ConfigurableFunctionsSet { get; set; }

      public virtual DbSet<ConfigurationCategories> ConfigurationCategoriesSet { get; set; }

      public virtual DbSet<Settings> SettingsSet { get; set; }


    /*  protected override void OnModelCreating(DbModelBuilder modelBuilder) {
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