using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace WorksoftConfigSystem.Models {
   public class CategoryMenuViewModel {

      public List<ConfigurationCategories> CategoryList { get; set; }


      public CategoryMenuViewModel() {


         //Fetch category data from datalayer

         CategoryList = new List<ConfigurationCategories>();

          DataLayer.DataLayer DL = new DataLayer.DataLayer();
          this.CategoryList = DL.ConfigurationCategoriesList;





         //Model1 db = new Model1();
         //
         //foreach(ConfigurationCategories cat in db.ConfigurationCategories) {
         //   CategoryList.Add(cat);
         //}


         //DataLayer.DatabaseContext db = new DataLayer.DatabaseContext();

        // var settings = db.ConfigurationCategoriesSet.ToList();

         Console.WriteLine();

      }

   }
}