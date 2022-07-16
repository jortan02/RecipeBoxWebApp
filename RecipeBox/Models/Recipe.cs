using Microsoft.AspNetCore.Http;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBox.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IFormFile Image { get; set; }
        public double Hours { get; set; }
        public int Servings { get; set; }
        public List<string> Ingredients { get; set; }
        public List<string> Directions { get; set; }

        public Recipe()
        {

        }
    }
}
