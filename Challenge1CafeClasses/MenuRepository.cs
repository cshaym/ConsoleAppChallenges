using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1CafeClasses
{
    public class MenuRepository     // Made this public so the ProgramUI could access it
    {
        private List<MenuClass> _listOfMeals = new List<MenuClass>();

        // Create: creating new menu items
        public void AddMealToList(MenuClass meal) 
        {
            _listOfMeals.Add(meal);
        }

        // Read: displaying list of all meals on cafe's menu (this views on the console)
        public List<MenuClass> GetMealList()
        {
            return _listOfMeals;
        }

        // Delete: deleting a meal(menu item)
        public bool RemoveMealFromList(string mealName)
        {
            MenuClass meal = GetMealByName(mealName);

            if (mealName == null)
            {
                return false;
            }

            int initialMeal = _listOfMeals.Count;    
            _listOfMeals.Remove(meal);

            if (initialMeal > _listOfMeals.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Helper method: Users can now enter a lowercase input for meal names
        public MenuClass GetMealByName(string mealName)
        {
            foreach (MenuClass meal in _listOfMeals)
            {
                if (meal.MealName.ToLower() == mealName.ToLower())  
                {
                    return meal;
                }
            }

            return null;
        }
    }
}
