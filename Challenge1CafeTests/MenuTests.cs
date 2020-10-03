using System;
using System.Collections.Generic;
using Challenge1CafeClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge1CafeTests
{
    [TestClass]
    public class MenuTests // We want to name it something related to what's being tested. In this case we are testing MenuRepository methods
    {
        // Format: public void NameOfMethod_Scenario_ExpectedBehavior()
        // Expected Behavior: Whatever your scenario is supposed to do
        //      - Ex: a bool where the UserIsAdmin will return true or return false. One scenario name is UserIsAdmin. One expected behavior name is ReturnsTrue.
        // Arrange
        // Make an instance of the repository
        // Make an instance of the business object
        // Get the count before we act 
        // Act
        // Run the add method
        // Assert
        // make sure that the count of the list in the repository is greater than the initial count
        // check that the first business object in your "Get all" method is the object you just added


        [TestMethod]
        public void AddMealToList_ShouldWork()
        { 
            // Arrange
            MenuRepository testRepo = new MenuRepository();
            MenuClass newMeal = new MenuClass { MealName = "Cookie", MealDescription = "Sugar cookie", MealNumber = 4, MealIngredients = "Flour, Milk, Sugar, Egg", MealPrice = 1 };
            List<MenuClass> _listOfMeals = new List<MenuClass>();
            
            // Act
            _listOfMeals.Add(newMeal);

            // Assert
            Assert.IsTrue(_listOfMeals.Count > 0);
        }

        [TestMethod]
        public void GetMealList_ShouldWork()
        {
            MenuRepository testRepo = new MenuRepository();
            
            List<MenuClass> _listOfMeals = testRepo.GetMealList();

            Console.WriteLine(_listOfMeals);

        }

        [TestMethod]
        public void RemoveMealFromList_ShouldWork()
        {
            MenuRepository testRepo = new MenuRepository();
            MenuClass newMeal = new MenuClass { MealName = "Cookie", MealDescription = "Sugar cookie", MealNumber = 4, MealIngredients = "Flour, Milk, Sugar, Egg", MealPrice = 1 };
            List<MenuClass> _listOfMeals = new List<MenuClass>();
            _listOfMeals.Add(newMeal);

            int initialMeal = _listOfMeals.Count;
            _listOfMeals.Remove(newMeal);

            if (initialMeal > _listOfMeals.Count)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        
    }
}
