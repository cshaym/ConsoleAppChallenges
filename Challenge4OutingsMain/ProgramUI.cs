using Challenge4OutingsLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4OutingsMain
{
    class ProgramUI
    {
        private OutingsRepo _eventRepo = new OutingsRepo();

        public void Run()
        {
            //SeedContentList();
            KomodoDisplay();
        }

        private void KomodoDisplay()
        {
            bool keepRunning = true;     
            while (keepRunning)          
            {
                Console.WriteLine("Welcome Komodo Accountants! Select a numbered option:\n" +
                    "\n" +
                    "1. View All Outings\n" +
                    "2. Create A New Outing\n" +
                    "3. View Total Outings Cost\n" +
                    "4. View A Specific Type Of Outing Cost\n" +
                    "5. Exit\n");
                
                string input = Console.ReadLine();     
                                                       
                switch (input)     
                {
                    case "1":
                        // View All Outings
                        ViewAllOutings();     
                        break;
                    case "2":
                        // Create A New Outing
                        CreateNewOuting();
                        break;
                    case "3":
                        // View Total Outings Cost
                        ViewTotalCost();
                        break;
                    case "4":
                        // View A Specific Type Of Outing Cost
                        ViewSpecificCost();
                        break;
                    case "5":
                        // Exit
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number 1-5.");
                        break;
                } // this "}" closes the switch case
                Console.WriteLine("Press any key to continue. . .");     
                Console.ReadKey();     
                Console.Clear();     
            } 
        }//-end of KomodoDisplay()-

        // case 1
        private void ViewAllOutings()
        {
            Console.Clear();     
            List<OutingsClass> _listOfOutings = _eventRepo.GetOutingList();   

            foreach (OutingsClass outing in _listOfOutings)   
            {
                Console.WriteLine($"Event Type: {outing.OutingType}\n" +
                    $"Number Of People That Attended: {outing.NumPeopleAttended}\n" +
                    $"Date Of Event: {outing.OutingDate}\n" +
                    $"Total Cost Per Person: ${outing.TotalPersonCost}\n" +
                    $"Total Cost for Event: ${outing.TotalOutingCost}\n");
            }
        }//-end of ViewAllOutings()-

        // case 2
        private void CreateNewOuting()
        {
            Console.Clear();

            OutingsClass newEvent = new OutingsClass();    
            // Outing Type
            Console.WriteLine("Enter the type of Event:");
            newEvent.OutingType = Console.ReadLine();
            // Number of People
            Console.WriteLine("How many people attended?:");
            string numPeopleAsString = Console.ReadLine();
            newEvent.NumPeopleAttended = int.Parse(numPeopleAsString);
            // Outing Date
            Console.WriteLine("Enter the date of the event (format example: 12-12-2000):");
            //DateTime date = new DateTime(2300, 12, 31);
            newEvent.OutingDate = DateTime.Parse(Console.ReadLine());  //
            // Total Person Cost
            Console.WriteLine("How much did it cost per person? Please do not use a dollar sign ($):");
            string numCostAsString = Console.ReadLine();     
            newEvent.TotalPersonCost = double.Parse(numCostAsString);     
            // Total Event Cost
            Console.WriteLine("How much did the event cost? Please do not use a dollar sign ($):");
            string numTotalCostAsString = Console.ReadLine();
            newEvent.TotalOutingCost = double.Parse(numTotalCostAsString);
            
            _eventRepo.AddOutingToList(newEvent);
        }//-end of CreateNewOuting()-

        // case 3----------this aint working--------------
        private void ViewTotalCost()
        {
            Console.Clear();

            List<OutingsClass> _costOfOutings = _eventRepo.GetCostList();

            foreach (OutingsClass outing in _costOfOutings)
            {
                Console.WriteLine($"Total amount spent on all outings: $" + outing.TotalOutingCost);
            }
        }//-end of ViewTotalCost()-

        // case 4
        private void ViewSpecificCost()
        {
            Console.Clear();    
            
            Console.WriteLine("Enter the type of event you'd like to see:");
            
            string specific = Console.ReadLine();     
            
            OutingsClass outing = _eventRepo.GetCostByType(specific);  
            
            if (outing != null)
            {
                Console.WriteLine("All events in the " + outing.OutingType + " category cost: $" + outing.TotalOutingCost);
            }
            else
            {
                Console.WriteLine("Sorry, no event by that name was found.");
            }
        }//-end of ViewSpecificCost()-

        // Seeds
        private void SeedContentList()
        {
            //OutingsClass golf = new OutingsClass("Golf", 24, 12/12/2020, 8.50, 304);
            //OutingsClass bowling = new OutingsClass("Bowling", 39, 2020 / 12 / 18, 12, 668);
            //OutingsClass amusementPark = new OutingsClass("Amusement Park", 11, 2020 / 12 / 18, 22, 342);
            //OutingsClass concert = new OutingsClass("Concert", 20, 2020 / 12 / 18, 30, 700);
        }
    }
}
