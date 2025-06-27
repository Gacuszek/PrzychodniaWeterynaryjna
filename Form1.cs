using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace przychodnia_weteranyjna_ulti
{
    public partial class Form1 : Form
    {
        private readonly PrzychodniaService _przychodniaService;

        public Form1()
        {
            InitializeComponent();
            _przychodniaService = new PrzychodniaService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OdswiezWszystkieDane();
        }

        private void OdswiezWszystkieDane()
        {
            ZaladujKlientow();
            ZaladujLekarzy();
            ZaladujWizyty();
            ZaladujDaneDoWizytComboBox();
            ZaladujPacjentowDoRaportu();
        }

        #region Logika Zak³adki Raporty
        private void ZaladujPacjentowDoRaportu()
        {
            cmbRaportPacjent.DataSource = null;
            cmbRaportPacjent.DataSource = _przychodniaService.PobierzWszystkieZwierzeta();
            cmbRaportPacjent.DisplayMember = "InfoDlaWizyty";
            cmbRaportPacjent.ValueMember = "Id";
            cmbRaportPacjent.SelectedIndex = -1;
            cmbRaportPacjent.Text = "Wybierz pacjenta...";
        }

        private void cmbRaportPacjent_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvRaportWizyty.DataSource = null;
            if (cmbRaportPacjent.SelectedItem is Zwierze wybranyPacjent)
            {
                if (dgvRaportWizyty.Columns.Count == 0)
                {
                    dgvRaportWizyty.AutoGenerateColumns = false;
                    dgvRaportWizyty.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Data Wizyty", DataPropertyName = "DataWizyty" });
                    dgvRaportWizyty.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Lekarz", DataPropertyName = "LekarzInfo" });
                    dgvRaportWizyty.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Status", DataPropertyName = "Status" });
                    dgvRaportWizyty.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Opis", DataPropertyName = "Opis", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
                }
                dgvRaportWizyty.DataSource = _przychodniaService.PobierzWizytyDlaPacjenta(wybranyPacjent.Id);
            }
            WyczyscPolaRaportu();
        }

        private void dgvRaportWizyty_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRaportWizyty.SelectedRows.Count > 0 && dgvRaportWizyty.SelectedRows[0].DataBoundItem is Wizyta zaznaczonaWizyta)
            {
                txtRaportBadanie.Text = zaznaczonaWizyta.Badanie;
                txtRaportDiagnoza.Text = zaznaczonaWizyta.Diagnoza;
                txtRaportZalecenia.Text = zaznaczonaWizyta.Zalecenia;
                txtRaportLeki.Text = zaznaczonaWizyta.Leki;
                txtRaportWaga.Text = zaznaczonaWizyta.Waga.ToString("F2");
                txtRaportTemperatura.Text = zaznaczonaWizyta.Temperatura.ToString("F1");
                txtRaportKoszt.Text = zaznaczonaWizyta.KosztWizyty.ToString("C");
                txtRaportDataKontroli.Text = zaznaczonaWizyta.DataKontroli?.ToShortDateString() ?? "Brak";
            }
            else
            {
                WyczyscPolaRaportu();
            }
        }

        private void WyczyscPolaRaportu()
        {
            txtRaportBadanie.Clear();
            txtRaportDiagnoza.Clear();
            txtRaportZalecenia.Clear();
            txtRaportLeki.Clear();
            txtRaportWaga.Clear();
            txtRaportTemperatura.Clear();
            txtRaportKoszt.Clear();
            txtRaportDataKontroli.Clear();
        }
        #endregion

        #region Logika Zak³adki Lekarze
        private void ZaladujLekarzy()
        {
            int? zaznaczoneId = null;
            if (dgvLekarze.SelectedRows.Count > 0 && dgvLekarze.SelectedRows[0].DataBoundItem is LekarzWeterynarii l) { zaznaczoneId = l.Id; }
            var lekarze = _przychodniaService.PobierzWszystkichLekarzy();
            dgvLekarze.DataSource = null;
            if (dgvLekarze.Columns.Count == 0)
            {
                dgvLekarze.AutoGenerateColumns = false;
                dgvLekarze.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Imiê", DataPropertyName = "Imie" });
                dgvLekarze.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nazwisko", DataPropertyName = "Nazwisko" });
                dgvLekarze.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Specjalizacja", DataPropertyName = "Specjalizacja" });
                dgvLekarze.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nr telefonu", DataPropertyName = "NumerTelefonu" });
                dgvLekarze.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nr PWZ", DataPropertyName = "NumerPWZ", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            }
            dgvLekarze.DataSource = lekarze;
            if (zaznaczoneId != null) { foreach (DataGridViewRow row in dgvLekarze.Rows) { if (row.DataBoundItem is LekarzWeterynarii lekarzInRow && lekarzInRow.Id == zaznaczoneId) { row.Selected = true; break; } } }
        }
        private void dgvLekarze_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLekarze.SelectedRows.Count > 0 && dgvLekarze.SelectedRows[0].DataBoundItem is LekarzWeterynarii zaznaczonyLekarz)
            {
                txtLekarzImie.Text = zaznaczonyLekarz.Imie;
                txtLekarzNazwisko.Text = zaznaczonyLekarz.Nazwisko;
                txtLekarzTelefon.Text = zaznaczonyLekarz.NumerTelefonu;
                txtLekarzPWZ.Text = zaznaczonyLekarz.NumerPWZ;
                txtLekarzSpecjalizacja.Text = zaznaczonyLekarz.Specjalizacja;
            }
            else { WyczyscPolaLekarza(); }
        }
        private void btnDodajLekarza_Click(object sender, EventArgs e)
        {
            try
            {
                var nowyLekarz = new LekarzWeterynarii { Imie = txtLekarzImie.Text, Nazwisko = txtLekarzNazwisko.Text, NumerTelefonu = txtLekarzTelefon.Text, NumerPWZ = txtLekarzPWZ.Text, Specjalizacja = txtLekarzSpecjalizacja.Text };
                _przychodniaService.AddLekarz(nowyLekarz);
                MessageBox.Show(this, "Nowy lekarz zosta³ pomyœlnie dodany.", "Sukces");
                OdswiezWszystkieDane();
            }
            catch (Exception ex) { MessageBox.Show(this, $"Wyst¹pi³ b³¹d: {ex.Message}", "B³¹d walidacji"); }
        }
        private void btnZapiszZmianyLekarz_Click(object sender, EventArgs e)
        {
            if (dgvLekarze.SelectedRows.Count == 0 || dgvLekarze.SelectedRows[0].DataBoundItem is not LekarzWeterynarii lekarzDoEdycji) { MessageBox.Show(this, "Proszê najpierw zaznaczyæ lekarza z listy.", "Brak wybranego lekarza"); return; }
            try
            {
                lekarzDoEdycji.Imie = txtLekarzImie.Text;
                lekarzDoEdycji.Nazwisko = txtLekarzNazwisko.Text;
                lekarzDoEdycji.NumerTelefonu = txtLekarzTelefon.Text;
                lekarzDoEdycji.NumerPWZ = txtLekarzPWZ.Text;
                lekarzDoEdycji.Specjalizacja = txtLekarzSpecjalizacja.Text;
                _przychodniaService.UpdateLekarz(lekarzDoEdycji);
                MessageBox.Show(this, "Dane lekarza zosta³y pomyœlnie zaktualizowane.", "Sukces");
                OdswiezWszystkieDane();
            }
            catch (Exception ex) { MessageBox.Show(this, $"Wyst¹pi³ b³¹d podczas zapisu zmian: {ex.Message}", "B³¹d"); }
        }
        private void btnUsunLekarza_Click(object sender, EventArgs e)
        {
            if (dgvLekarze.SelectedRows.Count == 0 || dgvLekarze.SelectedRows[0].DataBoundItem is not LekarzWeterynarii lekarzDoUsuniecia) { MessageBox.Show(this, "Proszê najpierw zaznaczyæ lekarza z listy.", "Brak wybranego lekarza"); return; }
            DialogResult wynik = MessageBox.Show(this, $"Czy na pewno chcesz usun¹æ lekarza: {lekarzDoUsuniecia.Imie} {lekarzDoUsuniecia.Nazwisko}?", "Potwierdzenie usuniêcia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (wynik == DialogResult.Yes)
            {
                try { _przychodniaService.DeleteLekarz(lekarzDoUsuniecia.Id); MessageBox.Show(this, "Lekarz zosta³ pomyœlnie usuniêty.", "Sukces"); OdswiezWszystkieDane(); }
                catch (Exception ex) { MessageBox.Show(this, $"Wyst¹pi³ b³¹d podczas usuwania: {ex.Message}", "B³¹d"); }
            }
        }
        private void WyczyscPolaLekarza() { txtLekarzImie.Clear(); txtLekarzNazwisko.Clear(); txtLekarzTelefon.Clear(); txtLekarzPWZ.Clear(); txtLekarzSpecjalizacja.Clear(); }
        #endregion

        #region Logika Zak³adki Wizyty
        private void ZaladujWizyty()
        {
            if (dgvWizyty == null) return;
            int? zaznaczoneId = null;
            if (dgvWizyty.SelectedRows.Count > 0 && dgvWizyty.SelectedRows[0].DataBoundItem is Wizyta w) { zaznaczoneId = w.Id; }
            var wizyty = _przychodniaService.PobierzWszystkieWizyty();
            dgvWizyty.DataSource = null;
            if (dgvWizyty.Columns.Count == 0)
            {
                dgvWizyty.AutoGenerateColumns = false;
                dgvWizyty.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Data Wizyty", DataPropertyName = "DataWizyty" });
                dgvWizyty.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Pacjent (W³aœciciel)", DataPropertyName = "PacjentInfo" });
                dgvWizyty.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Lekarz", DataPropertyName = "LekarzInfo" });
                dgvWizyty.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Status", DataPropertyName = "Status" });
                dgvWizyty.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Opis", DataPropertyName = "Opis", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            }
            dgvWizyty.DataSource = wizyty;
            if (zaznaczoneId != null) { foreach (DataGridViewRow row in dgvWizyty.Rows) { if (row.DataBoundItem is Wizyta wizytaInRow && wizytaInRow.Id == zaznaczoneId) { row.Selected = true; break; } } }
        }
        private void ZaladujDaneDoWizytComboBox()
        {
            cmbLekarz.DataSource = null;
            cmbLekarz.DataSource = _przychodniaService.PobierzWszystkichLekarzy();
            cmbLekarz.DisplayMember = "Info";
            cmbLekarz.ValueMember = "Id";
            cmbPacjent.DataSource = null;
            cmbPacjent.DataSource = _przychodniaService.PobierzWszystkieZwierzeta();
            cmbPacjent.DisplayMember = "InfoDlaWizyty";
            cmbPacjent.ValueMember = "Id";
        }
        private void dgvWizyty_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvWizyty.SelectedRows.Count > 0 && dgvWizyty.SelectedRows[0].DataBoundItem is Wizyta zaznaczonaWizyta)
            {
                if (zaznaczonaWizyta.Lekarz != null) cmbLekarz.SelectedValue = zaznaczonaWizyta.Lekarz.Id;
                if (zaznaczonaWizyta.Pacjent != null) cmbPacjent.SelectedValue = zaznaczonaWizyta.Pacjent.Id;
                dtpDataWizyty.Value = zaznaczonaWizyta.DataWizyty;
                txtOpisWizyty.Text = zaznaczonaWizyta.Opis;
                txtStatusWizyty.Text = zaznaczonaWizyta.Status;
                txtBadanie.Text = zaznaczonaWizyta.Badanie;
                txtDiagnoza.Text = zaznaczonaWizyta.Diagnoza;
                txtZalecenia.Text = zaznaczonaWizyta.Zalecenia;
                txtLeki.Text = zaznaczonaWizyta.Leki;
                numWaga.Value = (decimal)zaznaczonaWizyta.Waga;
                numTemperatura.Value = (decimal)zaznaczonaWizyta.Temperatura;
                numKosztWizyty.Value = zaznaczonaWizyta.KosztWizyty;
                if (zaznaczonaWizyta.DataKontroli.HasValue) { cbZaplanujKontrole.Checked = true; dtpDataKontroli.Value = zaznaczonaWizyta.DataKontroli.Value; } else { cbZaplanujKontrole.Checked = false; }
            }
        }
        private void btnUmowWizyte_Click(object sender, EventArgs e)
        {
            if (cmbLekarz.SelectedItem == null || cmbPacjent.SelectedItem == null) { MessageBox.Show(this, "Proszê wybraæ lekarza i pacjenta z listy.", "Brak danych"); return; }
            try
            {
                var nowaWizyta = new Wizyta { Lekarz = (LekarzWeterynarii)cmbLekarz.SelectedItem, Pacjent = (Zwierze)cmbPacjent.SelectedItem, DataWizyty = dtpDataWizyty.Value, Opis = txtOpisWizyty.Text, Status = txtStatusWizyty.Text, Badanie = txtBadanie.Text, Diagnoza = txtDiagnoza.Text, Zalecenia = txtZalecenia.Text, Leki = txtLeki.Text, Waga = (float)numWaga.Value, Temperatura = (float)numTemperatura.Value, KosztWizyty = numKosztWizyty.Value, DataKontroli = cbZaplanujKontrole.Checked ? dtpDataKontroli.Value : (DateTime?)null };
                _przychodniaService.UmowWizyte(nowaWizyta);
                MessageBox.Show(this, "Nowa wizyta zosta³a pomyœlnie umówiona.", "Sukces");
                OdswiezWszystkieDane();
            }
            catch (Exception ex) { MessageBox.Show(this, $"Wyst¹pi³ b³¹d podczas umawiania wizyty: {ex.Message}", "B³¹d"); }
        }
        private void btnZapiszZmianyWizyta_Click(object sender, EventArgs e)
        {
            if (dgvWizyty.SelectedRows.Count == 0 || dgvWizyty.SelectedRows[0].DataBoundItem is not Wizyta wizytaDoEdycji) { MessageBox.Show(this, "Proszê najpierw zaznaczyæ wizytê z tabeli, któr¹ chcesz edytowaæ.", "Brak wybranej wizyty"); return; }
            if (cmbLekarz.SelectedItem == null || cmbPacjent.SelectedItem == null) { MessageBox.Show(this, "Proszê wybraæ lekarza i pacjenta z listy.", "Brak danych"); return; }
            try
            {
                wizytaDoEdycji.Lekarz = (LekarzWeterynarii)cmbLekarz.SelectedItem;
                wizytaDoEdycji.Pacjent = (Zwierze)cmbPacjent.SelectedItem;
                wizytaDoEdycji.DataWizyty = dtpDataWizyty.Value;
                wizytaDoEdycji.Opis = txtOpisWizyty.Text;
                wizytaDoEdycji.Status = txtStatusWizyty.Text;
                wizytaDoEdycji.Badanie = txtBadanie.Text;
                wizytaDoEdycji.Diagnoza = txtDiagnoza.Text;
                wizytaDoEdycji.Zalecenia = txtZalecenia.Text;
                wizytaDoEdycji.Leki = txtLeki.Text;
                wizytaDoEdycji.Waga = (float)numWaga.Value;
                wizytaDoEdycji.Temperatura = (float)numTemperatura.Value;
                wizytaDoEdycji.KosztWizyty = numKosztWizyty.Value;
                wizytaDoEdycji.DataKontroli = cbZaplanujKontrole.Checked ? dtpDataKontroli.Value : (DateTime?)null;
                _przychodniaService.ZaktualizujWizyte(wizytaDoEdycji);
                MessageBox.Show(this, "Dane wizyty zosta³y pomyœlnie zaktualizowane.", "Sukces");
                OdswiezWszystkieDane();
            }
            catch (Exception ex) { MessageBox.Show(this, $"Wyst¹pi³ b³¹d podczas zapisu zmian: {ex.Message}", "B³¹d"); }
        }
        private void btnUsunWizyte_Click(object sender, EventArgs e)
        {
            if (dgvWizyty.SelectedRows.Count == 0 || dgvWizyty.SelectedRows[0].DataBoundItem is not Wizyta wizytaDoUsuniecia) { MessageBox.Show(this, "Proszê najpierw zaznaczyæ wizytê z tabeli, któr¹ chcesz usun¹æ.", "Brak wybranej wizyty"); return; }
            DialogResult wynik = MessageBox.Show(this, $"Czy na pewno chcesz usun¹æ tê wizytê?", "Potwierdzenie usuniêcia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (wynik == DialogResult.Yes)
            {
                try { _przychodniaService.UsunWizyte(wizytaDoUsuniecia.Id); MessageBox.Show(this, "Wizyta zosta³a pomyœlnie usuniêta.", "Sukces"); OdswiezWszystkieDane(); }
                catch (Exception ex) { MessageBox.Show(this, $"Wyst¹pi³ b³¹d podczas usuwania wizyty: {ex.Message}", "B³¹d"); }
            }
        }
        private void cbZaplanujKontrole_CheckedChanged(object sender, EventArgs e) { dtpDataKontroli.Enabled = cbZaplanujKontrole.Checked; }
        #endregion

        #region Logika Zak³adki Klienci i Zwierzêta
        private void ZaladujKlientow()
        {
            int? zaznaczoneId = (listBoxKlienci.SelectedItem as Klient)?.Id;
            var klienci = _przychodniaService.PobierzWszystkichKlientowZIchZwierzetami();
            listBoxKlienci.DataSource = null;
            listBoxKlienci.DataSource = klienci;
            listBoxKlienci.DisplayMember = "Nazwisko";
            if (zaznaczoneId != null) { for (int i = 0; i < listBoxKlienci.Items.Count; i++) { if ((listBoxKlienci.Items[i] as Klient)?.Id == zaznaczoneId) { listBoxKlienci.SelectedIndex = i; break; } } }
            if (listBoxKlienci.SelectedItem is Klient aktualnieZaznaczony)
            {
                listBoxZwierzeta.DataSource = null;
                listBoxZwierzeta.Items.Clear();
                if (aktualnieZaznaczony.Zwierzeta != null) { foreach (Zwierze zwierze in aktualnieZaznaczony.Zwierzeta) { listBoxZwierzeta.Items.Add(zwierze); } }
            }
            else
            {
                WyczyscPolaKlienta();
                WyczyscPolaZwierzecia();
                listBoxZwierzeta.DataSource = null;
                listBoxZwierzeta.Items.Clear();
            }
        }
        private void listBoxKlienci_SelectedIndexChanged(object sender, EventArgs e)
        {
            WyczyscPolaKlienta();
            WyczyscPolaZwierzecia();
            listBoxZwierzeta.DataSource = null;
            listBoxZwierzeta.Items.Clear();
            if (listBoxKlienci.SelectedItem is Klient zaznaczonyKlient)
            {
                txtImie.Text = zaznaczonyKlient.Imie;
                txtNazwisko.Text = zaznaczonyKlient.Nazwisko;
                txtTelefon.Text = zaznaczonyKlient.NumerTelefonu;
                txtEmail.Text = zaznaczonyKlient.Email;
                txtAdres.Text = zaznaczonyKlient.Adres;
                if (zaznaczonyKlient.Zwierzeta != null) { foreach (Zwierze zwierze in zaznaczonyKlient.Zwierzeta) { listBoxZwierzeta.Items.Add(zwierze); } }
            }
        }
        private void listBoxZwierzeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxZwierzeta.SelectedItem is Zwierze zaznaczoneZwierze)
            {
                txtImieZwierzecia.Text = zaznaczoneZwierze.Imie;
                txtGatunek.Text = zaznaczoneZwierze.Gatunek;
                txtRasa.Text = zaznaczoneZwierze.Rasa;
                dtpDataUrodzenia.Value = zaznaczoneZwierze.DataUrodzenia;
            }
            else { WyczyscPolaZwierzecia(); }
        }
        private void btnDodajKlienta_Click(object sender, EventArgs e)
        {
            try
            {
                var nowyKlient = new Klient { Imie = txtImie.Text, Nazwisko = txtNazwisko.Text, NumerTelefonu = txtTelefon.Text, Email = txtEmail.Text, Adres = txtAdres.Text };
                _przychodniaService.DodajKlienta(nowyKlient);
                MessageBox.Show(this, "Nowy klient zosta³ pomyœlnie dodany.", "Sukces");
                OdswiezWszystkieDane();
            }
            catch (Exception ex) { MessageBox.Show(this, $"Wyst¹pi³ b³¹d: {ex.Message}", "B³¹d walidacji"); }
        }
        private void btnZapiszZmiany_Click(object sender, EventArgs e)
        {
            if (listBoxKlienci.SelectedItem is not Klient klientDoEdycji) { MessageBox.Show(this, "Proszê najpierw zaznaczyæ klienta z listy, którego dane chcesz edytowaæ.", "Brak wybranego klienta"); return; }
            try
            {
                klientDoEdycji.Imie = txtImie.Text;
                klientDoEdycji.Nazwisko = txtNazwisko.Text;
                klientDoEdycji.NumerTelefonu = txtTelefon.Text;
                klientDoEdycji.Email = txtEmail.Text;
                klientDoEdycji.Adres = txtAdres.Text;
                _przychodniaService.ZaktualizujKlienta(klientDoEdycji);
                MessageBox.Show(this, "Dane klienta zosta³y pomyœlnie zaktualizowane.", "Sukces");
                OdswiezWszystkieDane();
            }
            catch (Exception ex) { MessageBox.Show(this, $"Wyst¹pi³ b³¹d: {ex.Message}", "B³¹d zapisu"); }
        }
        private void btnUsunKlienta_Click(object sender, EventArgs e)
        {
            if (listBoxKlienci.SelectedItem is not Klient klientDoUsuniecia) { MessageBox.Show(this, "Proszê najpierw zaznaczyæ klienta z listy, którego chcesz usun¹æ.", "Brak wybranego klienta"); return; }
            DialogResult wynik = MessageBox.Show(this, $"Czy na pewno chcesz usun¹æ klienta: {klientDoUsuniecia}?", "Potwierdzenie usuniêcia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (wynik == DialogResult.Yes)
            {
                try { _przychodniaService.UsunKlienta(klientDoUsuniecia.Id); MessageBox.Show(this, "Klient zosta³ pomyœlnie usuniêty.", "Sukces"); OdswiezWszystkieDane(); }
                catch (Exception ex) { MessageBox.Show(this, $"Wyst¹pi³ b³¹d podczas usuwania: {ex.Message}", "B³¹d"); }
            }
        }
        private void btnDodajZwierze_Click(object sender, EventArgs e)
        {
            if (listBoxKlienci.SelectedItem is not Klient wybranyKlient) { MessageBox.Show(this, "Proszê najpierw zaznaczyæ klienta z listy, do którego chcesz dodaæ zwierzê.", "Brak wybranego klienta"); return; }
            try
            {
                var noweZwierze = new Zwierze { Imie = txtImieZwierzecia.Text, Gatunek = txtGatunek.Text, Rasa = txtRasa.Text, DataUrodzenia = dtpDataUrodzenia.Value, Wlasciciel = wybranyKlient };
                _przychodniaService.DodajZwierze(noweZwierze);
                MessageBox.Show(this, "Nowe zwierzê zosta³o pomyœlnie dodane.", "Sukces");
                OdswiezWszystkieDane();
            }
            catch (Exception ex) { MessageBox.Show(this, $"Wyst¹pi³ b³¹d: {ex.Message}", "B³¹d walidacji"); }
        }
        private void btnZapiszZmianyZwierze_Click(object sender, EventArgs e)
        {
            if (listBoxZwierzeta.SelectedItem is not Zwierze zwierzeDoEdycji) { MessageBox.Show(this, "Proszê najpierw zaznaczyæ zwierzê z listy, którego dane chcesz edytowaæ.", "Brak wybranego zwierzêcia"); return; }
            try
            {
                zwierzeDoEdycji.Imie = txtImieZwierzecia.Text;
                zwierzeDoEdycji.Gatunek = txtGatunek.Text;
                zwierzeDoEdycji.Rasa = txtRasa.Text;
                zwierzeDoEdycji.DataUrodzenia = dtpDataUrodzenia.Value;
                _przychodniaService.ZaktualizujZwierze(zwierzeDoEdycji);
                MessageBox.Show(this, "Dane zwierzêcia zosta³y pomyœlnie zaktualizowane.", "Sukces");
                OdswiezWszystkieDane();
            }
            catch (Exception ex) { MessageBox.Show(this, $"Wyst¹pi³ b³¹d: {ex.Message}", "B³¹d zapisu"); }
        }
        private void btnUsunZwierze_Click(object sender, EventArgs e)
        {
            if (listBoxZwierzeta.SelectedItem is not Zwierze zwierzeDoUsuniecia) { MessageBox.Show(this, "Proszê najpierw zaznaczyæ zwierzê z listy, które chcesz usun¹æ.", "Brak wybranego klienta"); return; }
            DialogResult wynik = MessageBox.Show(this, $"Czy na pewno chcesz usun¹æ zwierzê: {zwierzeDoUsuniecia}?", "Potwierdzenie usuniêcia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (wynik == DialogResult.Yes)
            {
                try { _przychodniaService.UsunZwierze(zwierzeDoUsuniecia.Id); MessageBox.Show(this, "Zwierzê zosta³o pomyœlnie usuniête.", "Sukces"); OdswiezWszystkieDane(); }
                catch (Exception ex) { MessageBox.Show(this, $"Wyst¹pi³ b³¹d podczas usuwania: {ex.Message}", "B³¹d"); }
            }
        }
        private void WyczyscPolaKlienta() { txtImie.Clear(); txtNazwisko.Clear(); txtTelefon.Clear(); txtEmail.Clear(); txtAdres.Clear(); }
        private void WyczyscPolaZwierzecia() { txtImieZwierzecia.Clear(); txtGatunek.Clear(); txtRasa.Clear(); dtpDataUrodzenia.Value = DateTime.Now; }

        #endregion
    }
}