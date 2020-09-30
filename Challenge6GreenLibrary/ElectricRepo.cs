using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6GreenLibrary
{
    public class ElectricRepo
    {
        private List<ElectricClass> _listOfElectrics = new List<ElectricClass>();

        // Create: creating new vehicle to add
        public void AddElectricToList(ElectricClass make)
        {
            _listOfElectrics.Add(make);
        }

        // Read: displays list of electric vehicles
        public List<ElectricClass> GetElectricList()
        {
            return _listOfElectrics;
        }

        // Delete: delete a vehicle by make name
        public bool RemoveElectricFromList(string make)
        {
            ElectricClass electric = GetElectricByMake(make);

            if (make == null)
            {
                return false;
            }

            int initialElectric = _listOfElectrics.Count;     
            _listOfElectrics.Remove(electric);

            if (initialElectric > _listOfElectrics.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Helper method: Users can now enter a lowercase input for make names
        public ElectricClass GetElectricByMake(string make)
        {
            foreach (ElectricClass electric in _listOfElectrics)
            {
                if (electric.Make.ToLower() == make.ToLower())
                {
                    return electric;
                }
            }

            return null;
        }
    }
}
