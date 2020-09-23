using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ayce.Models.Components;

namespace ayce.Models.Pages
{
    public class DishPage
    {
        public void copyData(ButterCMS.Models.Page<DishPage> dishPage)
        {
            this.SEO = dishPage.Fields.SEO;
            this.DishTitle = dishPage.Fields.DishTitle;
            this.DishImage = dishPage.Fields.DishImage;
            this.DishDescription = dishPage.Fields.DishDescription;
            this.DishRecipe = dishPage.Fields.DishRecipe;
        }

        public Seo SEO { get; set; }
        public string DishTitle { get; set; }
        public string DishImage { get; set; }
        public string DishDescription { get; set; }
        public Recipe DishRecipe { get; set; }
    }
}