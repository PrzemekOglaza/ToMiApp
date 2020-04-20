using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToMi.BLL;

namespace ToMiBLLTesty
{
    [TestClass]
    public class DostawcaTesty
    {
        [TestMethod]
        public void WyslijEmailWitamy_PrawidlowaNazwaFirmy_Sukces()
        {
            // Arrange (zaranżuj test)
            var dostawca = new Dostawca();
            dostawca.NazwaFirmy = "ToMi";
            var wartoscOczekiwana = "Wiadomość wysłana: Witaj ToMi";
            
            //ACT (działenie)
            var wrtoscAktualna = dostawca.WyslijEmailWitamy("Wiadomosc testowa");

            //Assert (potwierdz test)
            Assert.AreEqual(wartoscOczekiwana, wrtoscAktualna);
        }

        [TestMethod]
        public void WyslijEmailWitamy_PustaNazwaFirmy()
        {
            // Arrange (zaranżuj test)
            var dostawca = new Dostawca();
            dostawca.NazwaFirmy = "";
            var wartoscOczekiwana = "Wiadomość wysłana: Witaj";
            
            //ACT (działenie)
            var wrtoscAktualna = dostawca.WyslijEmailWitamy("Wiadomosc testowa");

            //Assert (potwierdz test)
            Assert.AreEqual(wartoscOczekiwana, wrtoscAktualna);
        }

        [TestMethod]
        public void WyslijEmailWitamy_NullNazwaFirmy_Sukces()
        {
            // Arrange (zaranżuj test)
            var dostawca = new Dostawca();
            dostawca.NazwaFirmy = null;
            var wartoscOczekiwana = "Wiadomość wysłana: Witaj";
            
            //ACT (działenie)
            var wrtoscAktualna = dostawca.WyslijEmailWitamy("Wiadomosc testowa");

            //Assert (potwierdz test)
            Assert.AreEqual(wartoscOczekiwana, wrtoscAktualna);
        }
    }
}
