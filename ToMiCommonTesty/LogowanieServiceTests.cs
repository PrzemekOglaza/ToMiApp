using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ToMi.Common.Tests
{
    [TestClass()]
    public class LogowanieServiceTests
    {
        [TestMethod()]
        public void LogowanieTest()
        {
            // Arrange (zaaranzuj test)
            var oczekiwana = "Akcja: Test Akcja";

            // ACT (dzialaj)
            var aktualna = LogowanieService.Logowanie("Test Akcja");

            // Assert (potwierdz test)
            Assert.AreEqual(oczekiwana, aktualna);
        }
    }
}