using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorksoftConfigSystem.DataLayer;
using WorksoftConfigSystem.BusinessLogic;
using WorksoftConfigSystem.Models;

namespace WorksoftConfigSystem.Controllers
{
    public class HomeController : Controller
    {


      public ActionResult Index() {

         return View();

      }

      public ActionResult About() {

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {

            ViewBag.Message = "Your contact page.";

            return View();

        }



        //Shows the view with a table full of parameters where id = the category you want displayed.
        //Uses this from the Category sidebar to get the corresponding category
        public ActionResult Functions(int id) {


         BusinessLogic.BusinessLogic Bis = new BusinessLogic.BusinessLogic(new DataLayer.DataLayer());
         EditViewModel view = Bis.returnViewObject(id);
            
            return View(view);
        }


      //The model objects contains the values from the view that gets posted.
        [HttpPost]
        public ActionResult Functions(EditViewModel model) {

         //hiddenfor category
         /**
                  foreach(Functions func in model.functionsList) {
                     Bis.setFuncData(func);

                  }
                  foreach(ConfigurableFunctions configFunc in model.configFunctionsList) {
                     Bis.setConfigfuncData(configFunc);
                  }
            **/

         return View(model);
      }


      //For partial view model / sidebar
      [ChildActionOnly]
      public ActionResult partSideBar() {

         CategoryMenuViewModel model2 = new CategoryMenuViewModel();

         return View("partSideBar",model2);
      }

    }
}