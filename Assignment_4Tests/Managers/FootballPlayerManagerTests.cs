using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_4.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandaAssig_1;

namespace Assignment_4.Managers.Tests
{
    [TestClass()]
    public class FootballPlayerManagerTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            FootballPlayerManager manager = new FootballPlayerManager();

            List<FootballPlayer> allPlayers = manager.GetAll();
            Assert.AreEqual(2, allPlayers.Count);

            FootballPlayer player = manager.GetByID(1);
            Assert.AreEqual("Ronaldo", player.Title);

            Assert.IsNull(manager.GetByID(100));

            FootballPlayer newPlayer = new FootballPlayer { Name = "Pepe", Age = 33, shirtnumber = 54 };
            FootballPlayer addedPlayer = manager.Add(newPlayer);
            Assert.AreEqual(3, addedPlayer.Id);
            Assert.AreEqual(3, manager.GetAll().Count);

            FootballPlayer updates = new FootballPlayer { Name = "Modric", Age = 35, shirtnumber = 17 };
            FootballPlayer updatedPlayer = manager.Update(3, updates);
            Assert.AreEqual("Modric", updatedBook.Title);

            Assert.IsNull(manager.Update(100, updates));

            FootballPlayer deletedPlayer = manager.Delete(3);
            Assert.AreEqual("Modric", deletedPlayer.Title);
            Assert.AreEqual(2, manager.GetAll().Count);

            Assert.IsNull(manager.Delete(100));
        }
    }
}