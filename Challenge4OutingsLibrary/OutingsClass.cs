using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4OutingsLibrary
{
    public class OutingsClass
    {
        public string OutingType { get; set; }
        public int NumPeopleAttended { get; set; }     
        public DateTime OutingDate { get; set; }
        public double TotalPersonCost { get; set; }
        public double TotalOutingCost { get; set; }

        public OutingsClass() { }     

        public OutingsClass(string outingType, int numPeopleAttended, DateTime outingDate, double totalPersonCost, double totalOutingCost)  
        {
            OutingType = outingType;
            NumPeopleAttended = numPeopleAttended;
            OutingDate = outingDate;
            TotalPersonCost = totalPersonCost;
            TotalOutingCost = totalOutingCost;
        }
    }
}
