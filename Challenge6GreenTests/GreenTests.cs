using System;
using System.Collections.Generic;
using Challenge6GreenLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge6GreenTests
{
    [TestClass]
    public class GreenTests
    {
        [TestMethod]
        public void AddElectricToList_ShouldWork()
        {
            // Arrange
            ElectricRepo testRepo = new ElectricRepo();
            ElectricClass newElectric = new ElectricClass { Make = "Mitsubishi", Model = "Lancer", Year = 4, Price = 2, Miles = 1 };
            List<ElectricClass> _listOfElectrics = new List<ElectricClass>();

            // Act
            _listOfElectrics.Add(newElectric);

            // Assert
            Assert.IsTrue(_listOfElectrics.Count > 0);
        }
        [TestMethod]
        public void AddGasToList_ShouldWork()
        {
            GasRepo testRepo = new GasRepo();
            GasClass newGas = new GasClass { Make = "Mitsubishi", Model = "Lancer", Year = 4, Price = 2, Miles = 1 };
            List<GasClass> _listOfGased = new List<GasClass>();

            // Act
            _listOfGased.Add(newGas);

            // Assert
            Assert.IsTrue(_listOfGased.Count > 0);
        }
        [TestMethod]
        public void AddHybridToList_ShouldWork()
        {
            HybridRepo testRepo = new HybridRepo();
            HybridClass newHybrid = new HybridClass { Make = "Mitsubishi", Model = "Lancer", Year = 4, Price = 2, Miles = 1 };
            List<HybridClass> _listOfHybrids = new List<HybridClass>();

            // Act
            _listOfHybrids.Add(newHybrid);

            // Assert
            Assert.IsTrue(_listOfHybrids.Count > 0);
        }

        [TestMethod]
        public void GetElectricList_ShouldWork()
        {
            ElectricRepo testRepo = new ElectricRepo();

            List<ElectricClass> _listOfElectrics = testRepo.GetElectricList();

            Console.WriteLine(_listOfElectrics);

        }

        [TestMethod]
        public void GetGasList_ShouldWork()
        {
            GasRepo testRepo = new GasRepo();

            List<GasClass> _listOfGased = testRepo.GetGasList();

            Console.WriteLine(_listOfGased);

        }

        [TestMethod]
        public void GetHybridList_ShouldWork()
        {
            HybridRepo testRepo = new HybridRepo();

            List<HybridClass> _listOfHybrids = testRepo.GetHybridList();

            Console.WriteLine(_listOfHybrids);

        }

        [TestMethod]
        public void RemoveElectricFromList_ShouldWork()
        {
            ElectricRepo testRepo = new ElectricRepo();
            ElectricClass newElectric = new ElectricClass { Make = "Mitsubishi", Model = "Lancer", Year = 4, Price = 2, Miles = 1 };
            List<ElectricClass> _listOfElectrics = new List<ElectricClass>();
            _listOfElectrics.Add(newElectric);

            int initialElectric = _listOfElectrics.Count;
            _listOfElectrics.Remove(newElectric);

            if (initialElectric > _listOfElectrics.Count)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        [TestMethod]
        public void RemoveGasFromList_ShouldWork()
        {
            GasRepo testRepo = new GasRepo();
            GasClass newGas = new GasClass { Make = "Mitsubishi", Model = "Lancer", Year = 4, Price = 2, Miles = 1 };
            List<GasClass> _listOfGased = new List<GasClass>();
            _listOfGased.Add(newGas);

            int initialGas = _listOfGased.Count;
            _listOfGased.Remove(newGas);

            if (initialGas > _listOfGased.Count)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        [TestMethod]
        public void RemoveHybridFromList_ShouldWork()
        {
            HybridRepo testRepo = new HybridRepo();
            HybridClass newHybrid = new HybridClass { Make = "Mitsubishi", Model = "Lancer", Year = 4, Price = 2, Miles = 1 };
            List<HybridClass> _listOfHybrids = new List<HybridClass>();
            _listOfHybrids.Add(newHybrid);

            int initialHybrid = _listOfHybrids.Count;
            _listOfHybrids.Remove(newHybrid);

            if (initialHybrid > _listOfHybrids.Count)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

    }
}
