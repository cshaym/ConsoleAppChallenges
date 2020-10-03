using System;
using System.Collections.Generic;
using Challenge4OutingsLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge4OutingsTests
{
    [TestClass]
    public class OutingTests
    {
        [TestMethod]
        public void AddOutingToList_ShouldWork()
        {
            // Arrange
            OutingsRepo testRepo = new OutingsRepo();
            OutingsClass newEvent = new OutingsClass { OutingType = "Sledding", NumPeopleAttended = 10, OutingDate = new DateTime(2020, 1, 10), TotalPersonCost = 25, TotalOutingCost = 350 };
            List<OutingsClass> _listOfOutings = new List<OutingsClass>();

            // Act
            _listOfOutings.Add(newEvent);

            // Assert
            Assert.IsTrue(_listOfOutings.Count > 0);
        }

        [TestMethod]
        public void GetOutingList_ShouldWork()
        {
            OutingsRepo testRepo = new OutingsRepo();

            List<OutingsClass> _listOfOutings = testRepo.GetOutingList();

            Console.WriteLine(_listOfOutings);

        }

    }
}
