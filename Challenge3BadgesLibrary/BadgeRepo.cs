using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3BadgesLibrary
{
    public class BadgeRepo
    {
        private List<BadgeClass> _listOfBadges = new List<BadgeClass>();   // badge list
        private List<BadgeClass> _listOfDoors = new List<BadgeClass>();    // door list

        //Dictionaries
        //Dictionary<char, string> keyValuePair = new Dictionary<char, string>();
        //keyValuePair.Add('j', "Josh");

        // Create: add new badge to list
        public void AddBadgeToList(BadgeClass badge)
        {
            _listOfBadges.Add(badge);
        }

        // Create: add new door to list
        public void AddDoorToList(BadgeClass ldoors)
        {
            _listOfDoors.Add(ldoors);
        }

        // Read: display list with all badge numbers and their doors
        public List<BadgeClass> GetBadgeList()
        {
            return _listOfBadges;
        }

        // Update: update door access on an existing badge by name
        public bool UpdateExistingBadge(string originalName, BadgeClass newInfo)
        {
            //find the content
            BadgeClass oldInfo = GetBadgeByName(originalName);

            //update the content
            if (oldInfo != null)
            {
                oldInfo.Door = newInfo.Door;
                
                return true;
            }
            else
            {
                return false;
            }
        }

        // Delete: delete all doors from an existing badge
        public bool RemoveDoorsFromList(string door)
        {
            BadgeClass badge = GetBadgeByName(door);

            if (badge == null)
            {
                return false;
            }

            int initialCount = _listOfBadges.Count;
            _listOfBadges.Remove(badge);

            if (initialCount > _listOfBadges.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
