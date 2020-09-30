using Challenge1CafeClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1CafeMain
{
    class ProgramUI
    {
        private MenuRepository _menuRepo = new MenuRepository();    // _menuRepo is a field
        public void Run()      
        {
            SeedMealList();            // Added this to have pre-made examples
            DisplayMenu();             // The Run() method will run before the DisplayMenu() method fires off
        }

        private void DisplayMenu()     
        {
            // Added a while loop for the DisplayMenu() for the user to keep coming back to the menu until choosing to exit
            bool keepRunning = true;      
            while (keepRunning)          
            {
                // Displaying options to the user
                Console.WriteLine("Hello Komodo Cafe Management! Select a number option:\n" +
                    "1. Create New Menu Items\n" +
                    "2. View All Menu Items\n" +
                    "3. Delete Existing Menu Items\n" +
                    "4. Exit");
                // Getting the user's input
                string input = Console.ReadLine();     
                // Evaluate the user's input 
                switch (input)     
                    {
                        case "1":      
                            // Create New Menu Items
                            CreateNewMenuItem();       
                            break;
                        case "2":
                            // View All Menu Items
                            DisplayAllMenuItems();
                            break;
                        case "3":
                            // Delete Existing Menu Items
                            DeleteExistingMenuItem(); 
                        break;
                        case "4":
                            // Exit the app
                            Console.WriteLine("Goodbye!");
                            keepRunning = false;      // Breaks the while loop, finishing all the methods and exiting the app
                            break;
                        default:
                            Console.WriteLine("Please enter a valid number 1-4.");
                            break;
                    } 
                Console.WriteLine("Please press any key to continue. . .");     // This text will appear after any menu key is selected
                Console.ReadKey();     // Lets the user press something in order to start over back to the menu options
                Console.Clear();      
            } 
        } //-end of DisplayMenu()-

        // Create new menu items: case 1
        private void CreateNewMenuItem()
        {
            Console.Clear();    

            MenuClass newMeal = new MenuClass(); // Used "ctrl + ." to add a reference (from MenuRepository [which is an assembly]) so the "MenuClass" works. Top of page will now say using Challenge1CafeLibrary
            // MealName - [All these newMeal(s) are from what I created in MenuClass] 
            Console.WriteLine("Enter the name for the meal:");
            newMeal.MealName = Console.ReadLine().ToUpper();  
            // MealDescription
            Console.WriteLine("Enter a description for the meal:");
            newMeal.MealDescription = Console.ReadLine();
            // MealNumber 
            Console.WriteLine("Enter a number to be assigned to the meal:");   
            string numberAsString = Console.ReadLine();      // turns the numbers entered into a string since Console.ReadLine() only can return a string
            newMeal.MealNumber = int.Parse(numberAsString);  // Parse() method takes in numberAsString and converts the string of a number to an int
            // MealIngredients
            Console.WriteLine("Enter the ingredients used in this meal:");
            newMeal.MealIngredients = Console.ReadLine();  
            // MealPrice
            Console.WriteLine("How much will this meal cost? Feel free to enter a decimal number. Please do not include a dollar sign ($).");  
            string priceAsString = Console.ReadLine();
            newMeal.MealPrice = double.Parse(priceAsString);  
            
            _menuRepo.AddMealToList(newMeal); // Calling _menuRepo. The newMeal is the object i built with all the properties being set in the CreateNewMenuItem() and i added it to the _menuRepo which will then call _listOfMeals list and add new meals to that list       
        } //-end of CreateNewMenuItem()-

        // Display all menu items: case 2
        private void DisplayAllMenuItems()
        {
            Console.Clear();
            List<MenuClass> _listOfMeals = _menuRepo.GetMealList();   // GetMealList() is a method built in the repository. Its being saved as listOfMeals now
            // Show the list to the user
            foreach (MenuClass meal in _listOfMeals)      // means for each MenuClass object called meal (i want to show something on the console) so do what is in the {}
            {
                Console.WriteLine($"Meal Name: {meal.MealName}\n" +      
                    $"Meal Description: {meal.MealDescription}\n" +
                    $"Meal Number: {meal.MealNumber}\n" +
                    $"Meal Ingredients: {meal.MealIngredients}\n" +
                    $"Meal Price: ${meal.MealPrice}\n");
            }
        } //-end of DisplayAllMenuItem()-

        // Delete existing menu items: case 3
        private void DeleteExistingMenuItem()
        {
            DisplayAllMenuItems();   
            Console.WriteLine("\nEnter the name of the meal you'd like to remove:"); 
            string input = Console.ReadLine();       
            // Calling the delete method from MenuRepository.cs
            bool wasDeleted = _menuRepo.RemoveMealFromList(input);   
            
            if (wasDeleted)
            {
                Console.WriteLine("The meal was successfully deleted.");
            }
            else
            {
                Console.WriteLine("Sorry, the meal could not be deleted.");
            }
        } //-end of DeleteExistingMenuItem()-

        // Here are some pre-made meals I want inside the app
        private void SeedMealList()
        {
            MenuClass muffin = new MenuClass("CHOCOLATE MUFFIN", "Large classic chocolate chip muffin", 1, "Flour, Milk, Sugar, Chocolate chips", 1.99);
            MenuClass tea = new MenuClass("RAINBOW ICED TEA", "Large cup of fruit tea with layers of fresh fruit", 2, "Orange tea, Kiwi, Strawberry tea, Blueberry", 3.99);
            MenuClass pie = new MenuClass("APPLE PIE", "One large slice of warm apple pie", 3, "Flour, Sugar, Milk, Salt, Brown sugar, Apple", 2.99);

            _menuRepo.AddMealToList(muffin);
            _menuRepo.AddMealToList(tea);
            _menuRepo.AddMealToList(pie);
        }
    } //-end of ProgramUI-
}
