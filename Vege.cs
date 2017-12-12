using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaladNOW
{
    public class Vege
    {
        int id;
        public double price;
        public string name;
        public double calories;
        public double oil;
        public double cholesterol;
        public double sodium;
        public double potassium;
        public double carbohydrathes;
        public double protein;
        
        //Konstruktor
        public Vege(int id, double price, string name, double calories, double oil, double cholesterol, double sodium, double potassium, double carbohydrathes, double protein )
        {
            this.id = id;
            this.price = price;
            this.name = name;
            this.calories = calories;
            this.oil = oil;
            this.cholesterol = cholesterol;
            this.sodium = sodium;
            this.potassium = potassium;
            this.carbohydrathes = carbohydrathes;
            this.protein = protein;
            this.id = id;
            this.id = id;
        }
    }
}
