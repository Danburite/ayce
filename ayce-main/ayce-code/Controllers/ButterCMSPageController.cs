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
            var mainModel = new Pages.MainPage();

            ButterCMSClientHandler<Pages.MainPage> mainhandler = new ButterCMSClientHandler<Pages.MainPage>();

            mainhandler.modifyToMultiple(mainModel);
            
            var mainPageList = mainhandler.pagesClassType.Data.ToList();

            try
            {
                mainModel.copyData(mainPageList[0]);
            }
            catch (Exception ex)
            {
                return View("Error");
            }

            return View(mainModel);
        }

        [Route("dish/")]
        public ActionResult DishFeed(string slug)
        {
            var dishModel = new Pages.DishPage();

            ButterCMSClientHandler<Pages.DishPage> dishFeedHandler = new ButterCMSClientHandler<Pages.DishPage>();

            dishFeedHandler.modifyToMultiple(dishModel);

            var dishFeedModel = new Pages.DishFeedPage();

            try
            {
                dishFeedModel.DishCount = dishFeedHandler.pagesClassType.Meta.Count;

                dishFeedModel.Dishes = new List<Pages.DishPage>();
                var dishPageList = dishFeedHandler.pagesClassType.Data.ToList();

                foreach (var dish in dishPageList)
                {
                    var tempDish = new Pages.DishPage();

                    tempDish.copyData(dish);

                    dishFeedModel.Dishes.Add(tempDish);
                }
            }
            catch (Exception ex)
            {
                return View("Error");
            }
            
            return View(dishFeedModel);
        }

        [Route("dish/{slug}")]
        public ActionResult Dish(string slug)
        {
            var dishModel = new Pages.DishPage();

            ButterCMSClientHandler<Pages.DishPage> dishPageHandler = new ButterCMSClientHandler<Pages.DishPage>();

            dishPageHandler.modifyToSingle(dishModel, slug);

            try
            {
                dishModel.copyData(dishPageHandler.pageClassType.Data);
            }
            catch (Exception ex)
            {
                return View("Error");
            }

            return View(dishModel);
        }

        public class ButterCMSClientHandler<className> where className : class, new()
        {
            public ButterCMSClientHandler()
            {
                className tempClass = new className();
                butterClient = new ButterCMSClient("d185149ebfab8b4ca09538b4bb7fd3c2f7b0a80f");
            }

            public void modifyToMultiple(className slugType)
            {
                pagesClassType = new ButterCMS.Models.PagesResponse<className>();
                pagesClassType = butterClient.ListPages<className>(nameToPlug(slugType), null);
            }

            public void modifyToSingle(className slugType, string slugPage)
            {
                pageClassType = new ButterCMS.Models.PageResponse<className>();
                pageClassType = butterClient.RetrievePage<className>(nameToPlug(slugType), slugPage);
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

            public ButterCMS.Models.PagesResponse<className> pagesClassType { get; set; }
            public ButterCMS.Models.PageResponse<className> pageClassType { get; set; }
            public ButterCMSClient butterClient { get; set; }

        }
    }
}