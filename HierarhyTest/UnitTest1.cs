using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rocket;
using HierarhyForms;
using HierarhyForms.AchivemtObserver;

namespace HierarhyTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Rocket.Rocket rocket = new Rocket.Rocket();
        }
        [TestMethod]
        public void TestEmptyLevel()
        {
            StartObserver startObserver = new HierarhyForms.AchivemtObserver.StartObserver();
            Level.Init();
            Assert.IsTrue(startObserver.isChecked);
        }
        [TestMethod]
        public void TestPlayer()
        {
            Player player = new Player();
            player.Thrust();
        }
    }
}
