using Challenge6GreenLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6GreenMain
{
    class ProgramUI
    {
        private ElectricRepo _electricRepo = new ElectricRepo();
        private GasRepo _gasRepo = new GasRepo();
        private HybridRepo _hybridRepo = new HybridRepo();

        public void Run()
        {
            SeedMealList();            // Pre-made examples in the start-up app
            DisplayGreenPlan();             
        }

        private void DisplayGreenPlan()
        {
            bool keepRunning = true;      
            while (keepRunning)          
            {
                Console.WriteLine("Welcome to the Komodo Green Plan! Select a number option:\n" +
                    "\n" +
                    "1. View All Electric Vehicles\n" +
                    "2. Add A New Electric Vehicle\n" +
                    "3. Delete An Electric Vehicle\n" +
                    "-----------------------------\n" +
                    "4. View All Gas Vehicles\n" +
                    "5. Add A New Gas Vehicle\n" +
                    "6. Delete A Gas Vehicle\n" +
                    "-----------------------------\n" +
                    "7. View All Hybrid Vehicles\n" +
                    "8. Add A New Hybrid Vehicle\n" +
                    "9. Delete A Hybrid Vehicle\n" +
                    "-----------------------------\n" +
                    "10. Update An Electric Vehicle\n" +
                    "11. Update An Gas Vehicle\n" +
                    "12. Update An Hybrid Vehicle\n" +
                    "\n" +
                    "13. Exit");
                // Getting the user's input
                string input = Console.ReadLine();     
                // Evaluating
                switch (input)     
                {
                    case "1":
                        // View All Electric Vehicles
                        ViewAllElectric();       
                        break;
                    case "2":
                        // Add A New Electric Vehicle
                        AddNewElectric();
                        break;
                    case "3":
                        // Delete An Electric Vehicle
                        DeleteElectric();
                        break;
                    case "4":
                        // View All Gas Vehicles
                        ViewAllGas();
                        break;
                    case "5":
                        // Add A New Gas Vehicle
                        AddNewGas();
                        break;
                    case "6":
                        // Delete A Gas Vehicle
                        DeleteGas();
                        break;
                    case "7":
                        // View All Hybrid Vehicles
                        ViewAllHybrid();
                        break;
                    case "8":
                        // Add A New Hybrid Vehicle
                        AddNewHybrid();
                        break;
                    case "9":
                        // Delete A Hybrid Vehicle
                        DeleteHybrid();
                        break;
                    case "10":
                        // Update A Vehicle
                        UpdateExistingElectric();
                        break;
                    case "11":
                        UpdateExistingGas();
                        break;
                    case "12":
                        UpdateExistingHybrid();
                        break;
                    case "13":
                        // Exit
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number 1-10.");
                        break;
                }
                Console.WriteLine("Please press any key to continue. . .");  
                Console.ReadKey();     // Lets the user press something in order to start over back to the menu options
                Console.Clear();      
            } // this "}" closes the while loop
        } //-end of DisplayGreenPlan()-

        // case 1
        private void ViewAllElectric()
        {
            Console.Clear();
            List<ElectricClass> _listOfElectrics = _electricRepo.GetElectricList();   
            // Shows list to user
            foreach (ElectricClass electric in _listOfElectrics)      
            {
                Console.WriteLine($"Make: {electric.Make}\n" +      
                    $"Model: {electric.Model}\n" +
                    $"Year: {electric.Year}\n" +
                    $"Price: ${electric.Price}\n" +
                    $"Miles per battery: {electric.Miles} miles\n");
            }
        } //-end of ViewAllElectric()-

        // case 2
        private void AddNewElectric()
        {
            Console.Clear();

            ElectricClass newElectric = new ElectricClass(); 
            // Make  
            Console.WriteLine("Enter the make of the vehicle:");
            newElectric.Make = Console.ReadLine().ToUpper();
            // Model
            Console.WriteLine("Enter the model of the vehicle:");
            newElectric.Model = Console.ReadLine();
            // Year
            Console.WriteLine("Enter the year of the vehicle:");
            string yearAsString = Console.ReadLine();      
            newElectric.Year = int.Parse(yearAsString);  
            // Price
            Console.WriteLine("How much did the vehicle cost? Do not use a dollar sign($). No commas needed.:");
            string priceAsString = Console.ReadLine();
            newElectric.Price = int.Parse(priceAsString);
            // Miles
            Console.WriteLine("How many miles can it drive on a fully charged battery? (Numbers only please)");
            string milesAsString = Console.ReadLine();
            newElectric.Miles = int.Parse(milesAsString);
            
            _electricRepo.AddElectricToList(newElectric); 
        } //-end of AddNewElectric()-

        // case 3
        private void DeleteElectric()
        {
            // Gonna call the list so the user can see it, then ask them what they wanna remove from it
            ViewAllElectric();
            Console.WriteLine("\nEnter the model of the vehicle you'd like to remove. (Please write exact spelling and symbols):");
            string input = Console.ReadLine();       
            // Calling the delete method from the repo
            bool wasDeleted = _electricRepo.RemoveElectricFromList(input);

            if (wasDeleted)
            {
                Console.WriteLine("The vehicle was successfully deleted.");
            }
            else
            {
                Console.WriteLine("Sorry, the vehicle could not be deleted.");
            }
        } //-end of DeleteElectric()-

        // case 4
        private void ViewAllGas()
        {
            Console.Clear();
            List<GasClass> _listOfGas = _gasRepo.GetGasList();
            
            foreach (GasClass gas in _listOfGas)
            {
                Console.WriteLine($"Make: {gas.Make}\n" +
                    $"Model: {gas.Model}\n" +
                    $"Year: {gas.Year}\n" +
                    $"Price: ${gas.Price}\n" +
                    $"Miles per full tank: {gas.Miles} miles\n");
            }
        } //-end of ViewAllGas()-

        // case 5
        private void AddNewGas()
        {
            Console.Clear();

            GasClass newGas = new GasClass();
            // Make  
            Console.WriteLine("Enter the make of the vehicle:");
            newGas.Make = Console.ReadLine().ToUpper();
            // Model
            Console.WriteLine("Enter the model of the vehicle:");
            newGas.Model = Console.ReadLine();
            // Year
            Console.WriteLine("Enter the year of the vehicle:");
            string yearAsString = Console.ReadLine();
            newGas.Year = int.Parse(yearAsString);
            // Price
            Console.WriteLine("How much did the vehicle cost? Do not use a dollar sign($). No commas needed.:");
            string priceAsString = Console.ReadLine();
            newGas.Price = int.Parse(priceAsString);
            // Miles
            Console.WriteLine("How many miles can it drive on a full tank of gas? (Numbers only please)");
            string milesAsString = Console.ReadLine();
            newGas.Miles = int.Parse(milesAsString);

            _gasRepo.AddGasToList(newGas);
        } //-end of AddNewGas()-

        // case 6
        private void DeleteGas()
        {
            ViewAllGas();
            Console.WriteLine("\nEnter the model of the vehicle you'd like to remove. (Please write exact spelling and symbols):");
            string input = Console.ReadLine();
            
            bool wasDeleted = _gasRepo.RemoveGasFromList(input);

            if (wasDeleted)
            {
                Console.WriteLine("The vehicle was successfully deleted.");
            }
            else
            {
                Console.WriteLine("Sorry, the vehicle could not be deleted.");
            }
        } //-end of DeleteGas()-

        // case 7
        private void ViewAllHybrid()
        {
            Console.Clear();
            List<HybridClass> _listOfHybrid = _hybridRepo.GetHybridList();

            foreach (HybridClass hybrid in _listOfHybrid)
            {
                Console.WriteLine($"Make: {hybrid.Make}\n" +
                    $"Model: {hybrid.Model}\n" +
                    $"Year: {hybrid.Year}\n" +
                    $"Price: ${hybrid.Price}\n" +
                    $"Highest possible miles (full tank/full battery): {hybrid.Miles} miles\n");
            }
        } //-end of ViewAllHybrid()-

        // case 8
        private void AddNewHybrid()
        {
            Console.Clear();

            HybridClass newHybrid = new HybridClass();
            // Make  
            Console.WriteLine("Enter the make of the vehicle:");
            newHybrid.Make = Console.ReadLine().ToUpper();
            // Model
            Console.WriteLine("Enter the model of the vehicle:");
            newHybrid.Model = Console.ReadLine();
            // Year
            Console.WriteLine("Enter the year of the vehicle:");
            string yearAsString = Console.ReadLine();
            newHybrid.Year = int.Parse(yearAsString);
            // Price
            Console.WriteLine("How much did the vehicle cost? Do not use a dollar sign($). No commas needed.:");
            string priceAsString = Console.ReadLine();
            newHybrid.Price = int.Parse(priceAsString);
            // Miles
            Console.WriteLine("What is the highest number of miles it can drive fully charged or with a full tank of gas? Enter the highest number. (Numbers only please).");
            string milesAsString = Console.ReadLine();
            newHybrid.Miles = int.Parse(milesAsString);

            _hybridRepo.AddHybridToList(newHybrid);
        } //-end of AddNewHybrid()-

        // case 9
        private void DeleteHybrid()
        {
            ViewAllHybrid();

            Console.WriteLine("\nEnter the model of the vehicle you'd like to remove. (Please write exact spelling and symbols):");
            string input = Console.ReadLine();

            bool wasDeleted = _hybridRepo.RemoveHybridFromList(input);

            if (wasDeleted)
            {
                Console.WriteLine("The vehicle was successfully deleted.");
            }
            else
            {
                Console.WriteLine("Sorry, the vehicle could not be deleted.");
            }
        } //-end of DeleteHybrid()-

        // case 10
        private void UpdateExistingElectric()
        {
            Console.WriteLine("Enter the make of the vehicle you'd like to update:");
            string oldMake = Console.ReadLine();
            ElectricClass newMake = new ElectricClass();
            // Make  
            Console.WriteLine("Enter the make of the vehicle:");
            newMake.Make = Console.ReadLine().ToUpper();
            // Model
            Console.WriteLine("Enter the model of the vehicle:");
            newMake.Model = Console.ReadLine();
            // Year
            Console.WriteLine("Enter the year of the vehicle:");
            string yearAsString = Console.ReadLine();
            newMake.Year = int.Parse(yearAsString);
            // Price
            Console.WriteLine("How much did the vehicle cost? Do not use a dollar sign($). No commas needed.:");
            string priceAsString = Console.ReadLine();
            newMake.Price = int.Parse(priceAsString);
            // Miles
            Console.WriteLine("How many miles can it drive on a fully charged battery? (Numbers only please)");
            string milesAsString = Console.ReadLine();
            newMake.Miles = int.Parse(milesAsString);

            bool wasUpdated = _electricRepo.UpdateExistingElectric(oldMake, newMake);   
            if (wasUpdated)  
            {
                Console.WriteLine("Vehicle successfully updated!");
            }
            else
            {
                Console.WriteLine("Could not update vehicle.");
            }
        }

        // case 11
        private void UpdateExistingGas()
        {
            Console.WriteLine("Enter the make of the vehicle you'd like to update:");
            string oldMake = Console.ReadLine();
            GasClass newMake = new GasClass();
            // Make  
            Console.WriteLine("Enter the make of the vehicle:");
            newMake.Make = Console.ReadLine().ToUpper();
            // Model
            Console.WriteLine("Enter the model of the vehicle:");
            newMake.Model = Console.ReadLine();
            // Year
            Console.WriteLine("Enter the year of the vehicle:");
            string yearAsString = Console.ReadLine();
            newMake.Year = int.Parse(yearAsString);
            // Price
            Console.WriteLine("How much did the vehicle cost? Do not use a dollar sign($). No commas needed.:");
            string priceAsString = Console.ReadLine();
            newMake.Price = int.Parse(priceAsString);
            // Miles
            Console.WriteLine("How many miles can it drive on a fully charged battery? (Numbers only please)");
            string milesAsString = Console.ReadLine();
            newMake.Miles = int.Parse(milesAsString);

            bool wasUpdated = _gasRepo.UpdateExistingGas(oldMake, newMake);
            if (wasUpdated)
            {
                Console.WriteLine("Vehicle successfully updated!");
            }
            else
            {
                Console.WriteLine("Could not update vehicle.");
            }
        }

        // case 12
        private void UpdateExistingHybrid()
        {
            Console.WriteLine("Enter the make of the vehicle you'd like to update:");
            string oldMake = Console.ReadLine();
            HybridClass newMake = new HybridClass();
            // Make  
            Console.WriteLine("Enter the make of the vehicle:");
            newMake.Make = Console.ReadLine().ToUpper();
            // Model
            Console.WriteLine("Enter the model of the vehicle:");
            newMake.Model = Console.ReadLine();
            // Year
            Console.WriteLine("Enter the year of the vehicle:");
            string yearAsString = Console.ReadLine();
            newMake.Year = int.Parse(yearAsString);
            // Price
            Console.WriteLine("How much did the vehicle cost? Do not use a dollar sign($). No commas needed.:");
            string priceAsString = Console.ReadLine();
            newMake.Price = int.Parse(priceAsString);
            // Miles
            Console.WriteLine("How many miles can it drive on a fully charged battery? (Numbers only please)");
            string milesAsString = Console.ReadLine();
            newMake.Miles = int.Parse(milesAsString);

            bool wasUpdated = _hybridRepo.UpdateExistingHybrid(oldMake, newMake);
            if (wasUpdated)
            {
                Console.WriteLine("Vehicle successfully updated!");
            }
            else
            {
                Console.WriteLine("Could not update vehicle.");
            }
        }
        // Here are some pre-made vehicles I want inside the app
        private void SeedMealList()
        {
            ElectricClass extesla = new ElectricClass("TESLA", "Model X", 2020, 79990, 351);
            ElectricClass exnissan = new ElectricClass("NISSAN", "LEAF", 2020, 31600, 226);
            ElectricClass exjaguar = new ElectricClass("JAGUAR", "I-PACE", 2020, 69850, 234);
            GasClass exhonda = new GasClass("HONDA", "Civic", 2021, 22000, 40);
            GasClass exhyundai = new GasClass("HYUNDAI", "Elantra", 2020, 19300, 41);
            GasClass extoyota = new GasClass("TOYOTA", "Avalon", 2021, 35875, 34);
            HybridClass exkia = new HybridClass("KIA", "Optima", 2021, 30490, 32);

            _electricRepo.AddElectricToList(extesla);
            _electricRepo.AddElectricToList(exnissan);
            _electricRepo.AddElectricToList(exjaguar);
            _gasRepo.AddGasToList(exhonda);
            _gasRepo.AddGasToList(exhyundai);
            _gasRepo.AddGasToList(extoyota);
            _hybridRepo.AddHybridToList(exkia);
        }
    } //-end of ProgramUI-
}
