using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ButterCMS;
using Newtonsoft.Json;
using Pages = ayce.Models.Pages;

namespace ButterCMSPage.Controllers
{
    public class ButterCMSPageController : Controller
    {
        public ActionResult Main()
        {
            ButterCMSClientHandler<Pages.MainPage> mainhandler = new ButterCMSClientHandler<Pages.MainPage>("main_page");

            var mainModel = new Pages.MainPage();
            //Modify slugs on CMS to remove - delimiter and change components to accomodate
            var mainPageList = mainhandler.classType.Data.ToList();
            
            mainModel.copyData(mainPageList[0]);

            return View(mainModel);
        }

        public ActionResult Dish()
        {
            
            return View();
        }

        public class ButterCMSClientHandler<className> where className : class, new()
        {
            public ButterCMSClientHandler(string slug)
            {
                className tempClass = new className();
                var butterClient = new ButterCMSClient("d185149ebfab8b4ca09538b4bb7fd3c2f7b0a80f");
                classType = new ButterCMS.Models.PagesResponse<className>();
                //Dynamically change the "main" to page views
                classType = butterClient.ListPages<className>(slug, null);
            }

            //Implement for component plugs
            public string nameToPlug(className tempClass)
            {
                var classString = tempClass.ToString();

                classString = classString.Substring(classString.LastIndexOf(".")+1,(classString.Length) - (classString.LastIndexOf(".")+1));

                StringBuilder temp = new StringBuilder();

                for (int i = 0; i < classString.Length; i++)
                {
                    if (char.IsUpper(classString[i]) && i == 0)
                    {
                        temp.Append(char.ToLower(classString[i]));
                    }
                    else
                    {
                        if (char.IsUpper(classString[i]))
                        {
                            temp.Append("_");
                            temp.Append(char.ToLower(classString[i]));
                        }
                        else
                        {
                            temp.Append(char.ToLower(classString[i]));
                        }
                    }
                }

                return temp.ToString();
            }

            public ButterCMS.Models.PagesResponse<className> classType { get; set; }

        }
    }
}