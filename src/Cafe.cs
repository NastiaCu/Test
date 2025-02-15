using System;
using System.Collections.Generic;
using System.Linq;
using static Cafe.Messages;

namespace Cafe{
    public class Cafe{
        static List<Cook> cooks = new List<Cook>{
            new Cook("Alice"),
            new Cook("Bob"),
            new Cook("Charlie")
        };

        static List<Dish> menu = new List<Dish>{
            new Dish("Pasta", "Delicious pasta with tomato sauce", new List<Ingredient>{
                new Ingredient("Pasta", 2.5m),
                new Ingredient("Tomato Sauce", 1.5m),
                new Ingredient("Cheese", 1.0m)
            }, 15),
            new Dish("Salad", "Fresh garden salad", new List<Ingredient>
            {
                new Ingredient("Lettuce", 1.0m),
                new Ingredient("Tomato", 0.5m),
                new Ingredient("Cucumber", 0.5m),
                new Ingredient("Dressing", 0.5m)
            }, 10),
            new Dish("Pizza", "Fresh Proschutto Crudo Pizza from Italy", new List<Ingredient>
            {
                new Ingredient("Proschutto", 4.0m),
                new Ingredient("Tomato Sauce", 0.5m),
                new Ingredient("Lettuce", 1.0m)
            }, 20)
        };

        public static void ShowMenu(){
            Console.WriteLine("Menu:");
            foreach (var dish in menu){
                Console.WriteLine(dish);
                Console.WriteLine();
            }
        }

        public static void OrderDish(string dishName){
            var dish = menu.FirstOrDefault(d => d.name.Equals(dishName, StringComparison.OrdinalIgnoreCase));
            if (dish == null){
                Console.WriteLine(NOT_FOUND_MESSAGE);
                return;
            }

            var availableCook = cooks.OrderBy(c => c.dishInProg.Count).FirstOrDefault(c => c.CanTakeOrder());
            if (availableCook == null){
                Console.WriteLine(NOT_AVAILABLE_MESSAGE);
                return;
            }

            availableCook.dishInProg.Add(dish);
            int estimatedFinishTime = availableCook.GetTotalCookingTime();
            Console.WriteLine($"Your order has been placed with {availableCook.name}. Estimated cooking finish time: {estimatedFinishTime} minutes.");
        }
    }
}