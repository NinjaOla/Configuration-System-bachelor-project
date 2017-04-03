using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorksoftConfigSystem.Models {
   public class EditViewModel {

      public List<Settings> SettingsList { get; set; }
      public List<ConfigurableFunctions> ConfigurableFunctionsList { get; set; }
      public List<SelectListItem> CountryList;

      public string title { get; set; }

      public EditViewModel() {


         SettingsList = new List<Settings>();
         ConfigurableFunctionsList = new List<ConfigurableFunctions>();

         CountryList = new List<SelectListItem>();

         CountryList.Add(new SelectListItem
         {
            Text = "Norwegian",
            Value = "Norwegian",
         });

         CountryList.Add(new SelectListItem
         {
            Text = "Swedish",
            Value = "Swedish",
         });

         CountryList.Add(new SelectListItem
         {
            Text = "Finnish",
            Value = "Finnish",
         });

        }

      


   }
}