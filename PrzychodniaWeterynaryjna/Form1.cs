using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PrzychodniaWeterynaryjna
{
    public partial class Form1 : Form
    {
        private string connectionString; // Możesz przenieść connectionString tutaj do testowania

        public Form1()
        {
            InitializeComponent();
            // Jeśli connectionString jest stały dla całej aplikacji, zostaw go w DataAccess
            // Jeśli chcesz go mieć tutaj (np. do testowania połączenia), zainicjalizuj go
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\tomas\\OneDrive\\Desktop\\programowanie obiektowe\\PrzychodniaWeterynaryjna2\\PrzychodniaWeterynaryjna\\Baza_Danych\\Dane.accdb;Persist Security Info=False;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Kod wykonywany przy załadowaniu formularza
        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            // Opcjonalny test połączenia - zakomentuj, jeśli nie potrzebujesz go przy każdym logowaniu
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Połączenie z bazą danych nawiązane pomyślnie (test w Form1)!");
                    connection.Close();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show($"Błąd połączenia z bazą danych (test w Form1): {ex.Message}");
                    Console.WriteLine(ex.ToString());
                    return; // Przerwij logowanie, jeśli nie można się połączyć
                }
            }

            string login = txtLogin.Text;
            string haslo = txtHaslo.Text;

            DataAccess dataAccess = new DataAccess();
            Uzytkownik uzytkownik = dataAccess.PobierzUzytkownika(login, haslo);

            if (uzytkownik != null)
            {
                // Logowanie powiodło się
                MessageBox.Show($"Zalogowano jako: {uzytkownik.Imie} {uzytkownik.Nazwisko}", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                // Logowanie nie powiodło się
                MessageBox.Show("Nieprawidłowy login lub hasło.", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHaslo.Text = "";
            }
        }
    }
}