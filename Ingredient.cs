namespace Cafe{
    public class Ingredient{
        public string name { get; set; }
        public decimal price { get; set; }

        public Ingredient(string name, decimal price){
            this.name = name;
            this.price = price;
        }
    }
}