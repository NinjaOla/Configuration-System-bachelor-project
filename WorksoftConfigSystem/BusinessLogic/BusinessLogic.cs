using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorksoftConfigSystem.DataLayer;
using WorksoftConfigSystem.Models;

namespace WorksoftConfigSystem.BusinessLogic {
   public class BusinessLogic {

      public List<Settings> SettingsList = new List<Settings>();
      public List<ConfigurableFunctions> ConfigurableFunctionsList = new List<ConfigurableFunctions>();
      DataLayer.DataLayer Data;

      public BusinessLogic() {

      }

      public BusinessLogic(DataLayer.DataLayer layer) {
         this.Data = layer;

      }




      //public void getDatafromDataLayer(string ConfigurationCategoriesID) {

      //   //Data.fetchDBData();
      //   foreach(Settings s in Data.SettingsList) {
      //      if (s.ConfigurationCategoriesID.Equals(ConfigurationCategoriesID)) {
      //         SettingsList.Add(s);
      //      }
      //   }

      //   foreach (ConfigurableFunctions f in Data.ConfigurableFunctionsList) {
      //      if(f.ConfigurationCategoriesID.Equals(ConfigurationCategoriesID)) {
      //         ConfigurableFunctionsList.Add(f);
      //      }
      //   }
      //}


      public EditViewModel returnViewObject(int ConfigurationCategoriesID) {

         var viewObj = new EditViewModel();
         /*   
            getDatafromDataLayer(category);

            foreach(Settings func in SettingsList) {
               viewObj.SettingsList.Add(func);
            }
            foreach(ConfigurableFunctions conf in ConfigurableFunctionsList) {
               viewObj.ConfigurableFunctionsList.Add(conf);
            }
            */
         foreach(Settings setting in this.Data.SettingsList) {
            if (setting.ConfigurationCategoriesID == ConfigurationCategoriesID) viewObj.SettingsList.Add(setting);
         }

         foreach(ConfigurableFunctions conf in this.Data.ConfigurableFunctionsList) {
            if (conf.ConfigurationCategoriesID == ConfigurationCategoriesID) viewObj.ConfigurableFunctionsList.Add(conf);

         }



         return viewObj;

      }




   }


}