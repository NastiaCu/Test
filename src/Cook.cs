using System.Collections.Generic;

namespace Cafe{
    public class Cook{
        public string name { get; set; }
        public List<Dish> dishInProg { get; set; }

        public Cook(string name){
            this.name = name;
            this.dishInProg = new List<Dish>();
        }

        public bool CanTakeOrder(){
            return dishInProg.Count < 5;
        }

        public int GetTotalCookingTime(){
            int totalCookTime = 0;
            foreach (var dish in dishInProg){
                totalCookTime += dish.estCookTime;
            }
            return totalCookTime;
        }
    }
}