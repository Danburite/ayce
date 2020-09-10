using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ayce.Models.Components
{
    public class Recipe
    {
        public string RecipeType { get; set; }
        public string IngredientsList { get; set; }
        public string RecipeDescription { get; set; }
        public string ReferredURL { get; set; }
    }
}