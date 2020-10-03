using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3BadgesLibrary
{
    public class BadgeClass
    {
        public int BadgeID { get; set; }
        public string Door { get; set; }  // make this a list if it doesnt work
        public string Name { get; set; }
        
        public BadgeClass() { }     

        public BadgeClass(int badgeID, string door, string name)  
        {
            BadgeID = badgeID;
            Door = door;
            Name = name;
        }
    }
}
