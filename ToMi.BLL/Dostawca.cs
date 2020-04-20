using ToMi.Common;

namespace ToMi.BLL
{
    /// <summary>
    /// Zarządzanie dostawcami od których kupujemy produkty
    /// </summary>
    public class Dostawca
    {
        public int DostawcaId { get; set; }
        public string NazwaFirmy { get; set; }
        public string Email { get; set; }


        /// <summary>
        /// Wysyła wiadomość email z przywitaniem dostawcy
        /// </summary>
        /// <param name="wiadomosc"></param>
        /// <returns></returns>
        public string WyslijEmailWitamy(string wiadomosc)
        {
            var emailService = new EmailService();
            var temat = ("Witaj " + this.NazwaFirmy).Trim();
            var potwierdzenie = emailService.WyslijWiadomosc(temat, wiadomosc, this.Email);

            return potwierdzenie;
        }
    }
}
