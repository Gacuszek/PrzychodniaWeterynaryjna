using System;
using System.Windows.Forms;

namespace PrzychodniaWeterynaryjna
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Dodatkowy kod przy załadowaniu formularza głównego (jeśli istnieje)
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Możesz tutaj dodać ogólną logikę dla kliknięcia na elementy menu, jeśli potrzebujesz
        }

        private void plikToolStripMenuItem_Zakończ_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pacjenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZwierzetaForm pacjenciForm = new ZwierzetaForm(); // Wyświetli wszystkie zwierzęta
            pacjenciForm.Show();
        }

        private void klienciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KlienciForm klienciForm = new KlienciForm();
            klienciForm.Show();
        }
    }
}