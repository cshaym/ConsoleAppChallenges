using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4OutingsLibrary
{
    public class OutingsRepo
    {
        private List<OutingsClass> _listOfOutings = new List<OutingsClass>();
        private List<OutingsClass> _costOfOutings = new List<OutingsClass>();

        // Create: add outings to list
        public void AddOutingToList(OutingsClass outing)
        {
            _listOfOutings.Add(outing);
        }

        // Read: display list of all outings
        public List<OutingsClass> GetOutingList()
        {
            return _listOfOutings;
        }

        // Read: display combined cost for all outings
        public List<OutingsClass> GetCostList()
        {
            return _costOfOutings;
            
        }

        // Read: display outing costs (OutingType)
        //public List<OutingsClass> GetOutingList()
        //{
        //return _listOfOutings;
        //}

        // Helper Methods
        public OutingsClass GetCostByType(string specific)
        {
            foreach (OutingsClass outing in _listOfOutings)
            {
                if (outing.OutingType.ToLower() == specific.ToLower())  
                {
                    return outing;
                }
            }

            return null;
        }
    }
}
