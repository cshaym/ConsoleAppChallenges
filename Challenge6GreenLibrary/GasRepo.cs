using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6GreenLibrary
{
    public class GasRepo
    {
        private List<GasClass> _listOfGased = new List<GasClass>();

        // Create: creating new vehicle to add
        public void AddGasToList(GasClass make)
        {
            _listOfGased.Add(make);
        }

        // Read: displays list of gas vehicles
        public List<GasClass> GetGasList()
        {
            return _listOfGased;
        }

        // Update: each vehicle info
        public bool UpdateExistingGas(string originalMake, GasClass newMake)
        {
            //find the content 
            GasClass oldMake = GetGasByMake(originalMake);

            //update the content
            if (oldMake != null)
            {
                oldMake.Make = newMake.Make;
                oldMake.Model = newMake.Model;
                oldMake.Year = newMake.Year;
                oldMake.Price = newMake.Price;
                oldMake.Miles = newMake.Miles;

                return true;
            }
            else
            {
                return false;
            }
        }

        // Delete: delete a vehicle by make name
        public bool RemoveGasFromList(string make)
        {
            GasClass gas = GetGasByMake(make);

            if (make == null)
            {
                return false;
            }

            int initialGas = _listOfGased.Count;
            _listOfGased.Remove(gas);

            if (initialGas > _listOfGased.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Helper method: Users can now enter a lowercase input for make names
        public GasClass GetGasByMake(string make)
        {
            foreach (GasClass gas in _listOfGased)
            {
                if (gas.Make.ToLower() == make.ToLower())
                {
                    return gas;
                }
            }

            return null;
        }
    }
}
