using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1CafeClasses
{
    // MenuClass POCO (Plain Old C# Object)
    public class MenuClass
    {
         public string MealName { get; set; }
         public string MealDescription { get; set; }
         public int MealNumber { get; set; }     
         public string MealIngredients { get; set; }     
         public double MealPrice { get; set; }

         public MenuClass() { }     // MenuClass empty constructor
         
         public MenuClass(string mealName, string mealDescription, int mealNumber, string mealIngredients, double mealPrice)  //Parameters
         {
             MealName = mealName;
             MealDescription = mealDescription;
             MealNumber = mealNumber;
             MealIngredients = mealIngredients;
             MealPrice = mealPrice;
         }
    }
    
}

