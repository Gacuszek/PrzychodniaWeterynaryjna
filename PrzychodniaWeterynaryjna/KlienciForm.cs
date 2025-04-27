using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrzychodniaWeterynaryjna
{
    public partial class KlienciForm : Form
    {
        private DataAccess dataAccess = new DataAccess();
        private List<Klient> klienci;

        public KlienciForm()
        {
            InitializeComponent();
            PobierzWszystkichKlientowIZaktualizujListe();
        }

        private void PobierzWszystkichKlientowIZaktualizujListe()
        {
            klienci = dataAccess.PobierzWszystkichKlientow();
            dataGridView1.DataSource = klienci;
            UstawieniaKolumnKlientow();
        }

        private void UstawieniaKolumnKlientow()
        {
            dataGridView1.Columns["IdKlienta"].HeaderText = "ID";
            dataGridView1.Columns["Imie"].HeaderText = "Imię";
            dataGridView1.Columns["Nazwisko"].HeaderText = "Nazwisko";
            dataGridView1.Columns["Adres"].HeaderText = "Adres";
            dataGridView1.Columns["Telefon"].HeaderText = "Telefon";
        }

        private void dodajKlientaButton_Click(object sender, EventArgs e)
        {
            DodajKlientaForm dodajForm = new DodajKlientaForm();
            if (dodajForm.ShowDialog() == DialogResult.OK)
            {
                PobierzWszystkichKlientowIZaktualizujListe();
            }
        }

        private void edytujKlientaButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].DataBoundItem is Klient klientDoEdycji)
                {
                    EdytujKlientaForm edytujForm = new EdytujKlientaForm(klientDoEdycji);
                    if (edytujForm.ShowDialog() == DialogResult.OK)
                    {
                        PobierzWszystkichKlientowIZaktualizujListe();
                    }
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd podczas pobierania klienta do edycji.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Zaznacz klienta do edycji.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void usunKlientaButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].DataBoundItem is Klient klientDoUsuniecia)
                {
                    DialogResult result = MessageBox.Show($"Czy usunąć klienta o ID: {klientDoUsuniecia.IdKlienta}?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        if (dataAccess.UsunKlienta(klientDoUsuniecia.IdKlienta))
                        {
                            MessageBox.Show("Klient usunięty.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            PobierzWszystkichKlientowIZaktualizujListe();
                        }
                        else
                        {
                            MessageBox.Show("Błąd podczas usuwania klienta.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Błąd podczas pobierania klienta do usunięcia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Zaznacz klienta do usunięcia.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pokazZwierzetaButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].DataBoundItem is Klient wybranyKlient)
                {
                    int idWlasciciela = wybranyKlient.IdKlienta;
                    System.Diagnostics.Debug.WriteLine($"KlienciForm - Przekazuję ID właściciela: {idWlasciciela}");
                    ZwierzetaForm zwierzetaForm = new ZwierzetaForm(idWlasciciela);
                    zwierzetaForm.Show();
                }
                else
                {
                    MessageBox.Show("Błąd podczas pobierania informacji o kliencie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Zaznacz klienta, aby zobaczyć jego zwierzęta.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dodajZwierzeButtonCombo_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].DataBoundItem is Klient wybranyKlient)
                {
                    int idWlasciciela = wybranyKlient.IdKlienta;
                    DodajZwierzeForm dodajZwierzeForm = new DodajZwierzeForm(idWlasciciela);
                    if (dodajZwierzeForm.ShowDialog() == DialogResult.OK)
                    {
                        // Opcjonalnie: Odśwież listę klientów lub zwierząt
                    }
                }
                else
                {
                    MessageBox.Show("Zaznacz klienta, któremu chcesz dodać zwierzę.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Zaznacz klienta, aby dodać mu zwierzę.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funkcjonalność usuwania zwierząt wymagałaby kontrolki do wyboru zwierzęcia.", "Informacja");
        }
    }
}