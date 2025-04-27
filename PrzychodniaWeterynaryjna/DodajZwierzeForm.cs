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
    public partial class DodajZwierzeForm : Form
    {
        private int idWlasciciela;

        public DodajZwierzeForm(int idWlasciciela)
        {
            InitializeComponent();
            this.idWlasciciela = idWlasciciela;
        }

        private void zapiszButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(imieZwierzeciaTextBox.Text) || string.IsNullOrWhiteSpace(gatunekTextBox.Text))
            {
                MessageBox.Show("Proszę wypełnić imię i gatunek zwierzęcia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Pacjent nowyPacjent = new Pacjent(
     -1, // ID pacjenta
     "", "", "", // Puste stringi dla danych właściciela
     "", // Pusty string dla telefonu właściciela
     gatunekTextBox.Text,
     imieZwierzeciaTextBox.Text,
     dataUrodzeniaDateTimePicker.Value,
     idWlasciciela,
     null,
     null
 );

            DataAccess dataAccess = new DataAccess();
            if (dataAccess.DodajPacjenta(nowyPacjent))
            {
                MessageBox.Show("Zwierzę dodane pomyślnie.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK; // Zamknij formularz z wynikiem OK
                Close();
            }
            else
            {
                MessageBox.Show("Wystąpił błąd podczas dodawania zwierzęcia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void anulujButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}