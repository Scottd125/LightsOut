using Microsoft.VisualStudio.TestTools.UnitTesting;
using LightsOut;
using System.Linq;
using System.Windows.Forms;

namespace UnitTests
{
    [TestClass]
    public class LightsOutTests
    {
        [TestMethod]
        public void TestDefaultGridGameInitialization()
        {
            Grid grid = new Grid();
            grid.InitializeGame();
            Assert.AreEqual(grid.Lights.Length, 25);
            Assert.IsFalse(grid.IsWinCondition());
        }

        [TestMethod]
        public void TestDynamicGridGameInitialization()
        {
            Grid grid = new Grid(15, 15);
            grid.InitializeGame();
            Assert.AreEqual(grid.Lights.Length, 225);
            Assert.IsFalse(grid.IsWinCondition());
        }

        [TestMethod]
        public void TestGameWinCondition()
        {
            Grid grid = new Grid();
            grid.InitializeGame();

            // Turn off all lights after initializing game
            foreach (Light light in grid.Lights)
            {
                if (light.BackColor == Light.LightOnColour)
                {
                    light.BackColor = Light.LightOffColour;
                }
            }

            Assert.IsTrue(grid.IsWinCondition());
        }
    }
}
