using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorksoftConfigSystem.Models;
using WorksoftConfigSystem.Common.Extension;

namespace WorksoftConfigSystem.DataLayer {
   public class DataLayer : DatabaseContext {


      public List<Settings> SettingsList
      {
         get
         {
            return this.SettingsSet.ToList();
         }

      }

      public List<ConfigurableFunctions> ConfigurableFunctionsList
      {
         get
         {
            return this.ConfigurableFunctionsSet.ToList();
         }

      }

      public List<ConfigurationCategories> ConfigurationCategoriesList
      {
         get
         {
            return this.ConfigurationCategoriesSet.ToList();
         }

      }





      public DataLayer() :base() {
         


      }


      //For  updating the database, and not overwrite everything. -> call savechanges to actually update the DB.
      public void updateConfigurationEntry(ConfigurableFunctions entry) {

         //Check if entry 
         var dbEntry = this.ConfigurableFunctionsSet.Find(entry.ConfigurableFunctionID);

         if(dbEntry != null) {

            this.ConfigurableFunctionsSet.Update(entry);
            
         }
         else {

            this.ConfigurableFunctionsSet.Add(entry);
            
         }
         
      }


   }
  
}