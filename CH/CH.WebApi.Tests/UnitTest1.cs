using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CH.Manager;

namespace CH.WebApi.Tests
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// This is a unit test method for HomeManager.GetWelcomeMessage()
        /// </summary>
        [TestMethod]
        public void TestGetWelcomeMessage()
        {
            HomeManager homeManager = new HomeManager(new ManagerLogger());
            string message = homeManager.GetWelcomeMessage();
        }
    }
}
