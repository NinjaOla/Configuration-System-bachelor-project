using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WorksoftConfigSystem.Common.Extension {

   public static class DBSetExtension {

      public static void Update<E>(this DbSet<E> DBset, E entity) where E : class {
         //DataContext.Entry(entity).State = System.Data.EntityState.Modified;

         //Here can set the update logic for use. Import namespace to get accses, where we use DBSet
      }

   }
}