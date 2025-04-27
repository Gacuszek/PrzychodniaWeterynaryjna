using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzychodniaWeterynaryjna
{
    public class Pacjent
    {
        public int IdPacjenta { get; set; }
        public string ImieWlasciciela { get; set; }
        public string NazwiskoWlasciciela { get; set; }
        public string AdresWlasciciela { get; set; }
        public string TelefonWlasciciela { get; set; }
        public string Gatunek { get; set; }
        public string ImieZwierzecia { get; set; }
        public DateTime? DataUrodzenia { get; set; }
        public int IdWlasciciela { get; set; }
        public string Rasa { get; set; }
        public string Uwagi { get; set; }

        public Pacjent(int idPacjenta, string imieWlasciciela, string nazwiskoWlasciciela, string adresWlasciciela, string telefonWlasciciela, string gatunek, string imieZwierzecia, DateTime? dataUrodzenia, int idWlasciciela, string rasa = null, string uwagi = null)
        {
            IdPacjenta = idPacjenta;
            ImieWlasciciela = imieWlasciciela;
            NazwiskoWlasciciela = nazwiskoWlasciciela;
            AdresWlasciciela = adresWlasciciela;
            TelefonWlasciciela = telefonWlasciciela;
            Gatunek = gatunek;
            ImieZwierzecia = imieZwierzecia;
            DataUrodzenia = dataUrodzenia;
            IdWlasciciela = idWlasciciela;
            Rasa = rasa;
            Uwagi = uwagi;
        }
    }
}