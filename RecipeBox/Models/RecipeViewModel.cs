using Microsoft.AspNetCore.Http;
using RecipeBox.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBox.ViewModels
{
    public class RecipeViewModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public IFormFile Image { get; set; }
        [Required]
        public double Hours { get; set; }
        [Required]
        public int Servings { get; set; }
        [Required]
        public List<IngredientItem> Ingredients { get; set; }
        [Required]
        public List<DirectionStep> Directions { get; set; }
    }
}
