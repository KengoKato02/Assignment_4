using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_4.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;
using MandaAssig_1;

namespace Assignment_4.Managers.Tests
{
    [TestClass()]
    public class FootballPlayerManagerTests
    {
        [TestMethod()]
        public void GetByIDTest()
        {
            FootballPlayerManager manager = new FootballPlayerManager(); //Arrange
            FootballPlayer player = manager.GetByID(1); //Act
            Assert.AreEqual("Ronaldo", player.Name); //Assert
        }

        [TestMethod()]
        public void AddTest()
        {
            FootballPlayerManager manager = new FootballPlayerManager(); //Arrange
            FootballPlayer testingPlayer = new FootballPlayer(3, "pepe", 23, 19); //Act
            FootballPlayer player = manager.Add(testingPlayer); //Act
            Assert.AreEqual("pepe", player.Name); //Assert
        }
        
        [TestMethod()]
        public void UpdateTest()
        {
            FootballPlayerManager manager = new FootballPlayerManager(); //Arrange
            FootballPlayer newPlayer = new FootballPlayer(2, "lewandowski", 26, 32);
            FootballPlayer player = manager.Update(2, newPlayer);
            Assert.AreEqual("lewandowski", player.Name);
        }
    }
}