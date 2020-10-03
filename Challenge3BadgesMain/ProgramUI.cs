using Challenge3BadgesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3BadgesMain
{
    class ProgramUI
    {
        private BadgeRepo _contentRepo = new BadgeRepo();

        public void Run()      
        {
            //SeedContentList();     
            Menu();      
        }

        private void Menu()     
        {
            bool keepRunning = true;     
            while (keepRunning)         
            {
                Console.WriteLine("Hello Security Admin! Select a numbered option 1-4:\n" +
                    "\n" +
                    "1. Add a badge\n" +
                    "2. View all badges\n" +
                    "3. Edit a badge\n" +
                    "4. Exit");
                
                string input = Console.ReadLine();     
                                                       
                switch (input)     
                {
                    case "1":     
                        CreateNewBadge();     
                        break;
                    case "2":
                        DisplayAllBadges();
                        break;
                    case "3":
                        UpdateExistingBadge();
                        break;
                    case "4":
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number 1-4.");
                        break;
                } 
                Console.WriteLine("Please press any key to continue. . .");    
                Console.ReadKey();     
                Console.Clear();     
            } // this "}" closes the while loop
        }//-end of Menu()-

        // case 1
        private void CreateNewBadge()
        {
            Console.Clear();

            BadgeClass newInfo = new BadgeClass();    
            
            Console.WriteLine("Enter the employee name:");
            newInfo.Name = Console.ReadLine();
            
            Console.WriteLine("Enter the doors they need access to:");
            newInfo.Door = Console.ReadLine();
            
            Console.WriteLine("Enter the employee's ID:");
            string idAsString = Console.ReadLine();     
            newInfo.BadgeID = int.Parse(idAsString);
        }//-end of CreateNewBadge()-

        // case 2
        private void DisplayAllBadges()
        {
            Console.Clear();     
            List<BadgeClass> _listOfBadges = _contentRepo.GetBadgeList();   
            
            foreach (BadgeClass badge in _listOfBadges)   
            {
                Console.WriteLine($"Badge ID: {badge.BadgeID}\n" +
                    $"Door Access: {badge.Door}");
            }
        }//-end of DisplayAllBadges()-

        // case 3
        private void UpdateExistingBadge()
        {
            DisplayAllBadges();
            
            Console.WriteLine("Enter the employee name of the bage you'd like to update:");
            string oldEName = Console.ReadLine();

            BadgeClass newInfo = new BadgeClass();

            Console.WriteLine("Enter the employee name:");
            newInfo.Name = Console.ReadLine();

            Console.WriteLine("Enter the doors they need access to:");
            newInfo.Door = Console.ReadLine();

            Console.WriteLine("Enter the employee's ID:");
            string idAsString = Console.ReadLine();
            newInfo.BadgeID = int.Parse(idAsString);
            
            bool wasUpdated = _contentRepo.UpdateExistingBadge(oldEName, newInfo);   
            if (wasUpdated)  //meaning: if wasUpdated is true
            {
                Console.WriteLine("Badge successfully updated!");
            }
            else
            {
                Console.WriteLine("Could not update badge.");
            }
        }//-end of UpdateExistingBadge()-
    }//-end of ProgramUI-
}
