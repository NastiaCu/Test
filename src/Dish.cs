using System.Collections.Generic;
using System.Linq;

namespace Cafe{
    public class Dish{
        public string name { get; set; }
        public string description { get; set; }
        public List<Ingredient> ingredients { get; set; }
        public decimal price { get; set; }
        public int estCookTime { get; set; }

        public Dish(string name, string description, List<Ingredient> ingredients, int estCookTime){
            this.name = name;
            this.description = description;
            this.ingredients = ingredients;
            this.estCookTime = estCookTime;
            this.price = ingredients.Sum(i => i.price) * 1.2m;
        }

        public override string ToString(){
            string ingredientsList = string.Join(", ", ingredients.Select(i => i.name));
            return $"{name}: {description}\nIngredients: {ingredientsList}\nPrice: ${price:F2}\nEstimated Cooking Time: {estCookTime} minutes";
        }
    }
}