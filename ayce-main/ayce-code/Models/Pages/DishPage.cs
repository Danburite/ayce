using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ayce.Models.Components;

namespace ayce.Models.Pages
{
    public class DishPage
    {
        public string getRatingString()
        {
            string path = "";
            switch (DishRating)
            {
                case 1:
                    path = "/Assets/Icons/Rating/One_Star.svg";
                    break;
                case 2:
                    path = "/Assets/Icons/Rating/Two_Star.svg";
                    break;
                case 3:
                    path = "/Assets/Icons/Rating/Three_Star.svg";
                    break;
                case 4:
                    path = "/Assets/Icons/Rating/Four_Star.svg";
                    break;
                case 5:
                    path = "/Assets/Icons/Rating/Five_Star.svg";
                    break;
                default:
                    path = "~/Assets/Icons/Rating/Five_Star.svg";
                    break;
            }

            return path;
        }
        public void copyData(ButterCMS.Models.Page<DishPage> dishPage)
        {
            this.SEO = dishPage.Fields.SEO;
            this.Slug = dishPage.Slug;
            this.DishTitle = dishPage.Fields.DishTitle;
            this.DishRating = dishPage.Fields.DishRating;
            this.DishCuisine = dishPage.Fields.DishCuisine;
            this.DishImage = dishPage.Fields.DishImage;
            this.DishDescription = dishPage.Fields.DishDescription;
            this.DishRecipe = dishPage.Fields.DishRecipe;
        }

        public Seo SEO { get; set; }
        public string Slug { get; set; }
        public string DishTitle { get; set; }
        public int DishRating { get; set; }
        public string DishCuisine { get; set; }
        public string DishImage { get; set; }
        public string DishDescription { get; set; }
        public Recipe DishRecipe { get; set; }
    }
}