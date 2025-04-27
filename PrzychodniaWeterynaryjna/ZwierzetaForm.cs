using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PrzychodniaWeterynaryjna
{
    public partial class ZwierzetaForm : Form
    {
        private DataAccess dataAccess = new DataAccess();

        // Konstruktor do wyświetlania wszystkich zwierząt
        public ZwierzetaForm()
        {
            InitializeComponent();
            WyswietlWszystkieZwierzeta();
        }

        // Konstruktor do wyświetlania zwierząt danego właściciela
        public ZwierzetaForm(int idWlasciciela)
        {
            InitializeComponent();
            WyswietlZwierzeta(idWlasciciela);
        }

        private void ZwierzetaForm_Load(object sender, EventArgs e)
        {
            // Logika ładowania przeniesiona do konstruktorów
        }

        private void WyswietlWszystkieZwierzeta()
        {
            List<Pacjent> wszystkieZwierzeta = dataAccess.PobierzWszystkichPacjentow();
            dataGridView1.DataSource = wszystkieZwierzeta;
            UstawieniaKolumnZwierzecia();
            System.Diagnostics.Debug.WriteLine($"ZwierzetaForm - Wyświetlono wszystkie zwierzęta: {wszystkieZwierzeta?.Count}");
        }

        private void WyswietlZwierzeta(int idWlasciciela)
        {
            List<Pacjent> zwierzeta = dataAccess.PobierzZwierzetaDlaWlasciciela(idWlasciciela);
            dataGridView1.DataSource = zwierzeta;
            UstawieniaKolumnZwierzecia();
            System.Diagnostics.Debug.WriteLine($"ZwierzetaForm - Wyświetlono zwierzęta dla właściciela {idWlasciciela}: {zwierzeta?.Count}");
        }

        private void UstawieniaKolumnZwierzecia()
        {
            dataGridView1.Columns["IdPacjenta"].Visible = false;
            dataGridView1.Columns["IdWlasciciela"].Visible = false;
            dataGridView1.Columns["ImieWlasciciela"].HeaderText = "Imię właściciela";
            dataGridView1.Columns["NazwiskoWlasciciela"].HeaderText = "Nazwisko właściciela";
            dataGridView1.Columns["ImieZwierzecia"].HeaderText = "Imię";
            dataGridView1.Columns["Gatunek"].HeaderText = "Gatunek";
            dataGridView1.Columns["DataUrodzenia"].HeaderText = "Data urodzenia (zw.)";

            // Poprawione ustawienia dla pozostałych kolumn (dodano sprawdzenie czy istnieją)
            if (dataGridView1.Columns.Contains("TelefonWlasciciela"))
            {
                dataGridView1.Columns["TelefonWlasciciela"].HeaderText = "Telefon właściciela";
            }
            if (dataGridView1.Columns.Contains("AdresWlasciciela"))
            {
                dataGridView1.Columns["AdresWlasciciela"].HeaderText = "Adres właściciela";
            }
            if (dataGridView1.Columns.Contains("Rasa"))
            {
                dataGridView1.Columns["Rasa"].HeaderText = "Rasa";
            }
            if (dataGridView1.Columns.Contains("Uwagi"))
            {
                dataGridView1.Columns["Uwagi"].HeaderText = "Uwagi";
            }
            // Usunięto odwołanie do nieistniejącej kolumny "WlascicielDataUrodzenia"
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obsługa kliknięcia w komórkę (jeśli potrzebna)
        }
    }
}