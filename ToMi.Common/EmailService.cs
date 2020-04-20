namespace ToMi.Common
{
    public class EmailService
    {

        /// <summary>
        /// Wysyła wiadomość email
        /// </summary>
        /// <param name="temat">Temat wiadomości</param>
        /// <param name="wiadomosc">Treść wiadomości</param>
        /// <param name="odbiorca">Adres email odbiorcy</param>
        /// <returns></returns>
        public string WyslijWiadomosc(string temat, string wiadomosc, string odbiorca)
        {
            // Kod aby wysłać email do odbiorcy

            var potwierdzeni = "Wiadomość wysłana: " + temat;
            var logowanieService = new LogowanieService();
            logowanieService.Logowanie(potwierdzeni);

            return potwierdzeni;
        }
    }
}
