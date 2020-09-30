using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6GreenLibrary
{
    public class HybridRepo
    {
        private List<HybridClass> _listOfHybrids = new List<HybridClass>();

        // Create: creating new vehicle to add
        public void AddHybridToList(HybridClass make)
        {
            _listOfHybrids.Add(make);
        }

        // Read: displays list of hybrid vehicles
        public List<HybridClass> GetHybridList()
        {
            return _listOfHybrids;
        }

        // Delete: delete a vehicle by make name
        public bool RemoveHybridFromList(string make)
        {
            HybridClass hybrid = GetHybridByMake(make);

            if (make == null)
            {
                return false;
            }

            int initialHybrid = _listOfHybrids.Count;
            _listOfHybrids.Remove(hybrid);

            if (initialHybrid > _listOfHybrids.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Helper method: Users can now enter a lowercase input for make names
        public HybridClass GetHybridByMake(string make)
        {
            foreach (HybridClass hybrid in _listOfHybrids)
            {
                if (hybrid.Make.ToLower() == make.ToLower())
                {
                    return hybrid;
                }
            }

            return null;
        }
    }
}
