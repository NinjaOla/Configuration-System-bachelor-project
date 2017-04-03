using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace WorksoftConfigSystem.DataLayer {
   public static class Connection {
      
      public static string getConnectionString() {
         return ConfigurationManager.ConnectionStrings["azureWorksoftString"].ConnectionString;
      }


   }
}