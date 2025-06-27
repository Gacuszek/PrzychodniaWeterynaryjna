using System;
using System.Collections.Generic;
using System.Linq;

namespace przychodnia_weteranyjna_ulti
{
    public class PrzychodniaService
    {
        private readonly DataAccess _dataAccess;

        public PrzychodniaService()
        {
            _dataAccess = new DataAccess();
        }

        public List<Klient> PobierzWszystkichKlientowZIchZwierzetami()
        {
            List<Klient> wszyscyKlienci = _dataAccess.GetKlienci();
            List<Zwierze> wszystkieZwierzeta = _dataAccess.GetZwierzeta();
            foreach (var klient in wszyscyKlienci)
            {
                var zwierzetaTegoKlienta = wszystkieZwierzeta.Where(zwierze => zwierze.Wlasciciel.Id == klient.Id).ToList();
                foreach (var zwierze in zwierzetaTegoKlienta)
                {
                    zwierze.Wlasciciel = klient;
                }
                klient.Zwierzeta = zwierzetaTegoKlienta;
            }
            return wszyscyKlienci;
        }

        public void DodajKlienta(Klient nowyKlient) { _dataAccess.AddKlient(nowyKlient); }
        public void ZaktualizujKlienta(Klient klient) { _dataAccess.UpdateKlient(klient); }
        public void UsunKlienta(int klientId) { _dataAccess.DeleteKlient(klientId); }
        public void DodajZwierze(Zwierze noweZwierze) { _dataAccess.AddZwierze(noweZwierze); }
        public void ZaktualizujZwierze(Zwierze zwierze) { _dataAccess.UpdateZwierze(zwierze); }
        public void UsunZwierze(int zwierzeId) { _dataAccess.DeleteZwierze(zwierzeId); }
        public void AddLekarz(LekarzWeterynarii nowyLekarz) { _dataAccess.AddLekarz(nowyLekarz); }
        public void UpdateLekarz(LekarzWeterynarii lekarz) { _dataAccess.UpdateLekarz(lekarz); }
        public void DeleteLekarz(int lekarzId) { _dataAccess.DeleteLekarz(lekarzId); }
        public void UmowWizyte(Wizyta nowaWizyta) { _dataAccess.AddWizyta(nowaWizyta); }
        public void ZaktualizujWizyte(Wizyta wizyta) { _dataAccess.UpdateWizyta(wizyta); }
        public void UsunWizyte(int wizytaId) { _dataAccess.DeleteWizyta(wizytaId); }

        public List<Wizyta> PobierzWszystkieWizyty()
        {
            var wszystkieWizyty = _dataAccess.GetWizyty();
            var wszyscyLekarze = _dataAccess.GetLekarze();
            var wszyscyKlienci = PobierzWszystkichKlientowZIchZwierzetami();
            var wszystkieZwierzeta = wszyscyKlienci.SelectMany(klient => klient.Zwierzeta).ToList();
            foreach (var wizyta in wszystkieWizyty)
            {
                wizyta.Lekarz = wszyscyLekarze.FirstOrDefault(lekarz => lekarz.Id == wizyta.Lekarz.Id) ?? new LekarzWeterynarii { Nazwisko = "Brak danych" };
                wizyta.Pacjent = wszystkieZwierzeta.FirstOrDefault(zwierze => zwierze.Id == wizyta.Pacjent.Id) ?? new Zwierze { Imie = "Brak danych" };
            }
            return wszystkieWizyty;
        }

        public List<Wizyta> PobierzWizytyDlaPacjenta(int pacjentId)
        {
            var wizyty = _dataAccess.GetWizytyByPacjentId(pacjentId);
            var wszyscyLekarze = _dataAccess.GetLekarze();
            var pacjent = PobierzWszystkieZwierzeta().FirstOrDefault(z => z.Id == pacjentId);
            foreach (var wizyta in wizyty)
            {
                wizyta.Lekarz = wszyscyLekarze.FirstOrDefault(lekarz => lekarz.Id == wizyta.Lekarz.Id) ?? new LekarzWeterynarii();
                wizyta.Pacjent = pacjent ?? new Zwierze();
            }
            return wizyty;
        }

        public List<LekarzWeterynarii> PobierzWszystkichLekarzy()
        {
            return _dataAccess.GetLekarze();
        }

        public List<Zwierze> PobierzWszystkieZwierzeta()
        {
            var wszyscyKlienci = PobierzWszystkichKlientowZIchZwierzetami();
            var wszystkieZwierzeta = wszyscyKlienci.SelectMany(klient => klient.Zwierzeta).ToList();
            return wszystkieZwierzeta;
        }
    }
}