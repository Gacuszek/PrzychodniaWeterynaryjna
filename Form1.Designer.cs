namespace przychodnia_weteranyjna_ulti
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbWizyta = new TabPage();
            txtStatusWizyty = new TextBox();
            groupBox3 = new GroupBox();
            dtpDataKontroli = new DateTimePicker();
            cbZaplanujKontrole = new CheckBox();
            label27 = new Label();
            numKosztWizyty = new NumericUpDown();
            label26 = new Label();
            numTemperatura = new NumericUpDown();
            label25 = new Label();
            numWaga = new NumericUpDown();
            label24 = new Label();
            txtLeki = new TextBox();
            label23 = new Label();
            txtZalecenia = new TextBox();
            label22 = new Label();
            txtDiagnoza = new TextBox();
            label21 = new Label();
            txtBadanie = new TextBox();
            label20 = new Label();
            btnUsunWizyte = new Button();
            btnZapiszZmianyWizyta = new Button();
            btnUmowWizyte = new Button();
            txtOpisWizyty = new TextBox();
            dtpDataWizyty = new DateTimePicker();
            cmbPacjent = new ComboBox();
            cmbLekarz = new ComboBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label7 = new Label();
            dgvWizyty = new DataGridView();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            btnUsunZwierze = new Button();
            btnDodajZwierze = new Button();
            btnZapiszZmianyZwierze = new Button();
            txtRasa = new TextBox();
            txtGatunek = new TextBox();
            txtImieZwierzecia = new TextBox();
            dtpDataUrodzenia = new DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            btnUsunKlienta = new Button();
            btnZapiszZmiany = new Button();
            label5 = new Label();
            txtImie = new TextBox();
            label4 = new Label();
            txtNazwisko = new TextBox();
            label3 = new Label();
            txtTelefon = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            txtAdres = new TextBox();
            btnDodajKlienta = new Button();
            listBoxZwierzeta = new ListBox();
            listBoxKlienci = new ListBox();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            groupBox4 = new GroupBox();
            btnZapiszZmianyLekarz = new Button();
            btnUsunLekarza = new Button();
            btnDodajLekarza = new Button();
            txtLekarzSpecjalizacja = new TextBox();
            txtLekarzPWZ = new TextBox();
            txtLekarzTelefon = new TextBox();
            txtLekarzNazwisko = new TextBox();
            txtLekarzImie = new TextBox();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            dgvLekarze = new DataGridView();
            tabPage3 = new TabPage();
            gbRaportSzczegoly = new GroupBox();
            txtRaportDataKontroli = new TextBox();
            txtRaportKoszt = new TextBox();
            txtRaportTemperatura = new TextBox();
            txtRaportWaga = new TextBox();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            txtRaportLeki = new TextBox();
            label33 = new Label();
            txtRaportZalecenia = new TextBox();
            label34 = new Label();
            txtRaportDiagnoza = new TextBox();
            label35 = new Label();
            txtRaportBadanie = new TextBox();
            label36 = new Label();
            dgvRaportWizyty = new DataGridView();
            cmbRaportPacjent = new ComboBox();
            label28 = new Label();
            gbWizyta.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numKosztWizyty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTemperatura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWaga).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvWizyty).BeginInit();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLekarze).BeginInit();
            tabPage3.SuspendLayout();
            gbRaportSzczegoly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRaportWizyty).BeginInit();
            SuspendLayout();
            // 
            // gbWizyta
            // 
            gbWizyta.Controls.Add(txtStatusWizyty);
            gbWizyta.Controls.Add(groupBox3);
            gbWizyta.Controls.Add(dgvWizyty);
            gbWizyta.Location = new Point(4, 29);
            gbWizyta.Name = "gbWizyta";
            gbWizyta.Padding = new Padding(3);
            gbWizyta.Size = new Size(1631, 858);
            gbWizyta.TabIndex = 1;
            gbWizyta.Text = "Wizyty";
            gbWizyta.UseVisualStyleBackColor = true;
            // 
            // txtStatusWizyty
            // 
            txtStatusWizyty.Location = new Point(15, 599);
            txtStatusWizyty.Name = "txtStatusWizyty";
            txtStatusWizyty.Size = new Size(250, 27);
            txtStatusWizyty.TabIndex = 9;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtpDataKontroli);
            groupBox3.Controls.Add(cbZaplanujKontrole);
            groupBox3.Controls.Add(label27);
            groupBox3.Controls.Add(numKosztWizyty);
            groupBox3.Controls.Add(label26);
            groupBox3.Controls.Add(numTemperatura);
            groupBox3.Controls.Add(label25);
            groupBox3.Controls.Add(numWaga);
            groupBox3.Controls.Add(label24);
            groupBox3.Controls.Add(txtLeki);
            groupBox3.Controls.Add(label23);
            groupBox3.Controls.Add(txtZalecenia);
            groupBox3.Controls.Add(label22);
            groupBox3.Controls.Add(txtDiagnoza);
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(txtBadanie);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(btnUsunWizyte);
            groupBox3.Controls.Add(btnZapiszZmianyWizyta);
            groupBox3.Controls.Add(btnUmowWizyte);
            groupBox3.Controls.Add(txtOpisWizyty);
            groupBox3.Controls.Add(dtpDataWizyty);
            groupBox3.Controls.Add(cmbPacjent);
            groupBox3.Controls.Add(cmbLekarz);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(15, 259);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1268, 560);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Umów / Edytuj wizytę";
            // 
            // dtpDataKontroli
            // 
            dtpDataKontroli.Format = DateTimePickerFormat.Short;
            dtpDataKontroli.Location = new Point(834, 527);
            dtpDataKontroli.Name = "dtpDataKontroli";
            dtpDataKontroli.Size = new Size(124, 27);
            dtpDataKontroli.TabIndex = 29;
            // 
            // cbZaplanujKontrole
            // 
            cbZaplanujKontrole.AutoSize = true;
            cbZaplanujKontrole.Location = new Point(739, 529);
            cbZaplanujKontrole.Name = "cbZaplanujKontrole";
            cbZaplanujKontrole.Size = new Size(89, 24);
            cbZaplanujKontrole.TabIndex = 28;
            cbZaplanujKontrole.Text = "Zaplanuj";
            cbZaplanujKontrole.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(609, 530);
            label27.Name = "label27";
            label27.Size = new Size(124, 20);
            label27.TabIndex = 27;
            label27.Text = "Wizyta kontrolna:";
            // 
            // numKosztWizyty
            // 
            numKosztWizyty.DecimalPlaces = 2;
            numKosztWizyty.Location = new Point(739, 470);
            numKosztWizyty.Name = "numKosztWizyty";
            numKosztWizyty.Size = new Size(150, 27);
            numKosztWizyty.TabIndex = 26;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(606, 470);
            label26.Name = "label26";
            label26.Size = new Size(73, 20);
            label26.TabIndex = 25;
            label26.Text = "Koszt (zł):";
            // 
            // numTemperatura
            // 
            numTemperatura.DecimalPlaces = 1;
            numTemperatura.Location = new Point(739, 427);
            numTemperatura.Name = "numTemperatura";
            numTemperatura.Size = new Size(150, 27);
            numTemperatura.TabIndex = 24;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(603, 429);
            label25.Name = "label25";
            label25.Size = new Size(125, 20);
            label25.TabIndex = 23;
            label25.Text = "Temperatura (°C):";
            // 
            // numWaga
            // 
            numWaga.DecimalPlaces = 2;
            numWaga.Location = new Point(739, 387);
            numWaga.Name = "numWaga";
            numWaga.Size = new Size(150, 27);
            numWaga.TabIndex = 22;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(603, 389);
            label24.Name = "label24";
            label24.Size = new Size(80, 20);
            label24.TabIndex = 20;
            label24.Text = "Waga (kg):";
            // 
            // txtLeki
            // 
            txtLeki.Location = new Point(603, 294);
            txtLeki.Multiline = true;
            txtLeki.Name = "txtLeki";
            txtLeki.Size = new Size(512, 83);
            txtLeki.TabIndex = 19;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(603, 271);
            label23.Name = "label23";
            label23.Size = new Size(38, 20);
            label23.TabIndex = 18;
            label23.Text = "Leki:";
            // 
            // txtZalecenia
            // 
            txtZalecenia.Location = new Point(603, 163);
            txtZalecenia.Multiline = true;
            txtZalecenia.Name = "txtZalecenia";
            txtZalecenia.Size = new Size(512, 94);
            txtZalecenia.TabIndex = 17;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(603, 140);
            label22.Name = "label22";
            label22.Size = new Size(76, 20);
            label22.TabIndex = 16;
            label22.Text = "Zalecenia:";
            // 
            // txtDiagnoza
            // 
            txtDiagnoza.Location = new Point(603, 109);
            txtDiagnoza.Name = "txtDiagnoza";
            txtDiagnoza.Size = new Size(512, 27);
            txtDiagnoza.TabIndex = 15;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(603, 86);
            label21.Name = "label21";
            label21.Size = new Size(76, 20);
            label21.TabIndex = 14;
            label21.Text = "Diagnoza:";
            // 
            // txtBadanie
            // 
            txtBadanie.Location = new Point(603, 56);
            txtBadanie.Name = "txtBadanie";
            txtBadanie.Size = new Size(512, 27);
            txtBadanie.TabIndex = 13;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(603, 32);
            label20.Name = "label20";
            label20.Size = new Size(66, 20);
            label20.TabIndex = 12;
            label20.Text = "Badanie:";
            // 
            // btnUsunWizyte
            // 
            btnUsunWizyte.Location = new Point(0, 453);
            btnUsunWizyte.Name = "btnUsunWizyte";
            btnUsunWizyte.Size = new Size(250, 29);
            btnUsunWizyte.TabIndex = 11;
            btnUsunWizyte.Text = "Anuluj/Usuń wizytę";
            btnUsunWizyte.UseVisualStyleBackColor = true;
            btnUsunWizyte.Click += btnUsunWizyte_Click;
            // 
            // btnZapiszZmianyWizyta
            // 
            btnZapiszZmianyWizyta.Location = new Point(0, 418);
            btnZapiszZmianyWizyta.Name = "btnZapiszZmianyWizyta";
            btnZapiszZmianyWizyta.Size = new Size(250, 29);
            btnZapiszZmianyWizyta.TabIndex = 10;
            btnZapiszZmianyWizyta.Text = "Zapisz zmiany";
            btnZapiszZmianyWizyta.UseVisualStyleBackColor = true;
            btnZapiszZmianyWizyta.Click += btnZapiszZmianyWizyta_Click;
            // 
            // btnUmowWizyte
            // 
            btnUmowWizyte.Location = new Point(0, 383);
            btnUmowWizyte.Name = "btnUmowWizyte";
            btnUmowWizyte.Size = new Size(250, 29);
            btnUmowWizyte.TabIndex = 9;
            btnUmowWizyte.Text = "Umów wizytę";
            btnUmowWizyte.UseVisualStyleBackColor = true;
            btnUmowWizyte.Click += btnUmowWizyte_Click;
            // 
            // txtOpisWizyty
            // 
            txtOpisWizyty.Location = new Point(0, 214);
            txtOpisWizyty.Multiline = true;
            txtOpisWizyty.Name = "txtOpisWizyty";
            txtOpisWizyty.Size = new Size(244, 86);
            txtOpisWizyty.TabIndex = 8;
            // 
            // dtpDataWizyty
            // 
            dtpDataWizyty.Format = DateTimePickerFormat.Custom;
            dtpDataWizyty.Location = new Point(0, 161);
            dtpDataWizyty.Name = "dtpDataWizyty";
            dtpDataWizyty.Size = new Size(250, 27);
            dtpDataWizyty.TabIndex = 7;
            // 
            // cmbPacjent
            // 
            cmbPacjent.FormattingEnabled = true;
            cmbPacjent.Location = new Point(0, 109);
            cmbPacjent.Name = "cmbPacjent";
            cmbPacjent.Size = new Size(250, 28);
            cmbPacjent.TabIndex = 6;
            // 
            // cmbLekarz
            // 
            cmbLekarz.FormattingEnabled = true;
            cmbLekarz.Location = new Point(0, 55);
            cmbLekarz.Name = "cmbLekarz";
            cmbLekarz.Size = new Size(250, 28);
            cmbLekarz.TabIndex = 5;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(0, 86);
            label14.Name = "label14";
            label14.Size = new Size(59, 20);
            label14.TabIndex = 4;
            label14.Text = "Pacjent:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(0, 140);
            label13.Name = "label13";
            label13.Size = new Size(110, 20);
            label13.TabIndex = 3;
            label13.Text = "Data i godzina:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 191);
            label12.Name = "label12";
            label12.Size = new Size(42, 20);
            label12.TabIndex = 2;
            label12.Text = "Opis:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 317);
            label11.Name = "label11";
            label11.Size = new Size(52, 20);
            label11.TabIndex = 1;
            label11.Text = "Status:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 32);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 0;
            label7.Text = "Lekarz:";
            // 
            // dgvWizyty
            // 
            dgvWizyty.AllowUserToAddRows = false;
            dgvWizyty.AllowUserToDeleteRows = false;
            dgvWizyty.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvWizyty.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWizyty.Location = new Point(8, 6);
            dgvWizyty.Name = "dgvWizyty";
            dgvWizyty.ReadOnly = true;
            dgvWizyty.RowHeadersWidth = 51;
            dgvWizyty.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvWizyty.Size = new Size(1592, 238);
            dgvWizyty.TabIndex = 0;
            dgvWizyty.SelectionChanged += dgvWizyty_SelectionChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(listBoxZwierzeta);
            tabPage1.Controls.Add(listBoxKlienci);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1631, 858);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Klienci i Zwierzęta";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnUsunZwierze);
            groupBox2.Controls.Add(btnDodajZwierze);
            groupBox2.Controls.Add(btnZapiszZmianyZwierze);
            groupBox2.Controls.Add(txtRasa);
            groupBox2.Controls.Add(txtGatunek);
            groupBox2.Controls.Add(txtImieZwierzecia);
            groupBox2.Controls.Add(dtpDataUrodzenia);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(509, 350);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(414, 430);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dodaj zwierzę dla klienta";
            // 
            // btnUsunZwierze
            // 
            btnUsunZwierze.Location = new Point(71, 353);
            btnUsunZwierze.Name = "btnUsunZwierze";
            btnUsunZwierze.Size = new Size(274, 29);
            btnUsunZwierze.TabIndex = 17;
            btnUsunZwierze.Text = "Usuń zwierzę";
            btnUsunZwierze.UseVisualStyleBackColor = true;
            btnUsunZwierze.Click += btnUsunZwierze_Click;
            // 
            // btnDodajZwierze
            // 
            btnDodajZwierze.Location = new Point(71, 285);
            btnDodajZwierze.Name = "btnDodajZwierze";
            btnDodajZwierze.Size = new Size(274, 29);
            btnDodajZwierze.TabIndex = 14;
            btnDodajZwierze.Text = "Dodaj zwierzę";
            btnDodajZwierze.UseVisualStyleBackColor = true;
            btnDodajZwierze.Click += btnDodajZwierze_Click;
            // 
            // btnZapiszZmianyZwierze
            // 
            btnZapiszZmianyZwierze.Location = new Point(71, 320);
            btnZapiszZmianyZwierze.Name = "btnZapiszZmianyZwierze";
            btnZapiszZmianyZwierze.Size = new Size(274, 29);
            btnZapiszZmianyZwierze.TabIndex = 16;
            btnZapiszZmianyZwierze.Text = "Zapisz zmiany";
            btnZapiszZmianyZwierze.UseVisualStyleBackColor = true;
            btnZapiszZmianyZwierze.Click += btnZapiszZmianyZwierze_Click;
            // 
            // txtRasa
            // 
            txtRasa.Location = new Point(81, 95);
            txtRasa.Name = "txtRasa";
            txtRasa.Size = new Size(193, 27);
            txtRasa.TabIndex = 21;
            // 
            // txtGatunek
            // 
            txtGatunek.Location = new Point(81, 62);
            txtGatunek.Name = "txtGatunek";
            txtGatunek.Size = new Size(193, 27);
            txtGatunek.TabIndex = 20;
            // 
            // txtImieZwierzecia
            // 
            txtImieZwierzecia.Location = new Point(81, 29);
            txtImieZwierzecia.Name = "txtImieZwierzecia";
            txtImieZwierzecia.Size = new Size(193, 27);
            txtImieZwierzecia.TabIndex = 14;
            // 
            // dtpDataUrodzenia
            // 
            dtpDataUrodzenia.Location = new Point(81, 126);
            dtpDataUrodzenia.Name = "dtpDataUrodzenia";
            dtpDataUrodzenia.Size = new Size(193, 27);
            dtpDataUrodzenia.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(0, 65);
            label10.Name = "label10";
            label10.Size = new Size(66, 20);
            label10.TabIndex = 18;
            label10.Text = "Gatunek:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(0, 98);
            label9.Name = "label9";
            label9.Size = new Size(43, 20);
            label9.TabIndex = 17;
            label9.Text = "Rasa:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 131);
            label8.Name = "label8";
            label8.Size = new Size(64, 20);
            label8.TabIndex = 16;
            label8.Text = "Data ur.:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 32);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 14;
            label6.Text = "Imię:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUsunKlienta);
            groupBox1.Controls.Add(btnZapiszZmiany);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtImie);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNazwisko);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTelefon);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtAdres);
            groupBox1.Controls.Add(btnDodajKlienta);
            groupBox1.Location = new Point(21, 350);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(416, 430);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodaj nowego klienta";
            // 
            // btnUsunKlienta
            // 
            btnUsunKlienta.Location = new Point(58, 370);
            btnUsunKlienta.Name = "btnUsunKlienta";
            btnUsunKlienta.Size = new Size(274, 29);
            btnUsunKlienta.TabIndex = 15;
            btnUsunKlienta.Text = "Usuń klienta";
            btnUsunKlienta.UseVisualStyleBackColor = true;
            btnUsunKlienta.Click += btnUsunKlienta_Click;
            // 
            // btnZapiszZmiany
            // 
            btnZapiszZmiany.Location = new Point(58, 335);
            btnZapiszZmiany.Name = "btnZapiszZmiany";
            btnZapiszZmiany.Size = new Size(274, 29);
            btnZapiszZmiany.TabIndex = 14;
            btnZapiszZmiany.Text = "Zapisz zmiany";
            btnZapiszZmiany.UseVisualStyleBackColor = true;
            btnZapiszZmiany.Click += btnZapiszZmiany_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 75);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 13;
            label5.Text = "Nazwisko:";
            // 
            // txtImie
            // 
            txtImie.Location = new Point(81, 42);
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(193, 27);
            txtImie.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 108);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 12;
            label4.Text = "Telefon:";
            // 
            // txtNazwisko
            // 
            txtNazwisko.Location = new Point(79, 75);
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.Size = new Size(195, 27);
            txtNazwisko.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 141);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 11;
            label3.Text = "Email:";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(81, 108);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(195, 27);
            txtTelefon.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 174);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 10;
            label2.Text = "Adres:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(79, 141);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(195, 27);
            txtEmail.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 42);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 9;
            label1.Text = "Imię:";
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(79, 174);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(195, 27);
            txtAdres.TabIndex = 7;
            // 
            // btnDodajKlienta
            // 
            btnDodajKlienta.Location = new Point(58, 290);
            btnDodajKlienta.Name = "btnDodajKlienta";
            btnDodajKlienta.Size = new Size(274, 29);
            btnDodajKlienta.TabIndex = 8;
            btnDodajKlienta.Text = "Dodaj klienta";
            btnDodajKlienta.UseVisualStyleBackColor = true;
            btnDodajKlienta.Click += btnDodajKlienta_Click;
            // 
            // listBoxZwierzeta
            // 
            listBoxZwierzeta.FormattingEnabled = true;
            listBoxZwierzeta.Location = new Point(507, 7);
            listBoxZwierzeta.Margin = new Padding(3, 4, 3, 4);
            listBoxZwierzeta.Name = "listBoxZwierzeta";
            listBoxZwierzeta.Size = new Size(416, 304);
            listBoxZwierzeta.TabIndex = 10;
            listBoxZwierzeta.SelectedIndexChanged += listBoxZwierzeta_SelectedIndexChanged;
            // 
            // listBoxKlienci
            // 
            listBoxKlienci.FormattingEnabled = true;
            listBoxKlienci.Location = new Point(21, 7);
            listBoxKlienci.Margin = new Padding(3, 4, 3, 4);
            listBoxKlienci.Name = "listBoxKlienci";
            listBoxKlienci.Size = new Size(416, 304);
            listBoxKlienci.TabIndex = 9;
            listBoxKlienci.SelectedIndexChanged += listBoxKlienci_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(gbWizyta);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1639, 891);
            tabControl1.TabIndex = 9;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(dgvLekarze);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(1631, 858);
            tabPage2.TabIndex = 2;
            tabPage2.Text = "Lekarze";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnZapiszZmianyLekarz);
            groupBox4.Controls.Add(btnUsunLekarza);
            groupBox4.Controls.Add(btnDodajLekarza);
            groupBox4.Controls.Add(txtLekarzSpecjalizacja);
            groupBox4.Controls.Add(txtLekarzPWZ);
            groupBox4.Controls.Add(txtLekarzTelefon);
            groupBox4.Controls.Add(txtLekarzNazwisko);
            groupBox4.Controls.Add(txtLekarzImie);
            groupBox4.Controls.Add(label19);
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(label15);
            groupBox4.Location = new Point(1183, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(448, 458);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Dodaj / Edytuj Lekarza";
            // 
            // btnZapiszZmianyLekarz
            // 
            btnZapiszZmianyLekarz.Location = new Point(128, 337);
            btnZapiszZmianyLekarz.Name = "btnZapiszZmianyLekarz";
            btnZapiszZmianyLekarz.Size = new Size(235, 29);
            btnZapiszZmianyLekarz.TabIndex = 12;
            btnZapiszZmianyLekarz.Text = "Zapisz zmiany";
            btnZapiszZmianyLekarz.UseVisualStyleBackColor = true;
            btnZapiszZmianyLekarz.Click += btnZapiszZmianyLekarz_Click;
            // 
            // btnUsunLekarza
            // 
            btnUsunLekarza.Location = new Point(128, 403);
            btnUsunLekarza.Name = "btnUsunLekarza";
            btnUsunLekarza.Size = new Size(235, 29);
            btnUsunLekarza.TabIndex = 11;
            btnUsunLekarza.Text = "Usuń lekarza";
            btnUsunLekarza.UseVisualStyleBackColor = true;
            btnUsunLekarza.Click += btnUsunLekarza_Click;
            // 
            // btnDodajLekarza
            // 
            btnDodajLekarza.Location = new Point(128, 272);
            btnDodajLekarza.Name = "btnDodajLekarza";
            btnDodajLekarza.Size = new Size(235, 29);
            btnDodajLekarza.TabIndex = 10;
            btnDodajLekarza.Text = "Dodaj lekarza";
            btnDodajLekarza.UseVisualStyleBackColor = true;
            btnDodajLekarza.Click += btnDodajLekarza_Click;
            // 
            // txtLekarzSpecjalizacja
            // 
            txtLekarzSpecjalizacja.Location = new Point(128, 212);
            txtLekarzSpecjalizacja.Name = "txtLekarzSpecjalizacja";
            txtLekarzSpecjalizacja.Size = new Size(293, 27);
            txtLekarzSpecjalizacja.TabIndex = 9;
            // 
            // txtLekarzPWZ
            // 
            txtLekarzPWZ.Location = new Point(128, 166);
            txtLekarzPWZ.Name = "txtLekarzPWZ";
            txtLekarzPWZ.Size = new Size(293, 27);
            txtLekarzPWZ.TabIndex = 8;
            // 
            // txtLekarzTelefon
            // 
            txtLekarzTelefon.Location = new Point(128, 128);
            txtLekarzTelefon.Name = "txtLekarzTelefon";
            txtLekarzTelefon.Size = new Size(293, 27);
            txtLekarzTelefon.TabIndex = 7;
            // 
            // txtLekarzNazwisko
            // 
            txtLekarzNazwisko.Location = new Point(128, 88);
            txtLekarzNazwisko.Name = "txtLekarzNazwisko";
            txtLekarzNazwisko.Size = new Size(293, 27);
            txtLekarzNazwisko.TabIndex = 6;
            // 
            // txtLekarzImie
            // 
            txtLekarzImie.Location = new Point(128, 52);
            txtLekarzImie.Name = "txtLekarzImie";
            txtLekarzImie.Size = new Size(293, 27);
            txtLekarzImie.TabIndex = 5;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(26, 91);
            label19.Name = "label19";
            label19.Size = new Size(72, 20);
            label19.TabIndex = 4;
            label19.Text = "Nazwisko";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(26, 128);
            label18.Name = "label18";
            label18.Size = new Size(58, 20);
            label18.TabIndex = 3;
            label18.Text = "Telefon";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(26, 173);
            label17.Name = "label17";
            label17.Size = new Size(40, 20);
            label17.TabIndex = 2;
            label17.Text = "PWZ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(26, 219);
            label16.Name = "label16";
            label16.Size = new Size(95, 20);
            label16.TabIndex = 1;
            label16.Text = "Specjalizacja";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(26, 55);
            label15.Name = "label15";
            label15.Size = new Size(38, 20);
            label15.TabIndex = 0;
            label15.Text = "Imie";
            // 
            // dgvLekarze
            // 
            dgvLekarze.AllowUserToAddRows = false;
            dgvLekarze.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLekarze.Dock = DockStyle.Left;
            dgvLekarze.Location = new Point(0, 0);
            dgvLekarze.Name = "dgvLekarze";
            dgvLekarze.ReadOnly = true;
            dgvLekarze.RowHeadersWidth = 51;
            dgvLekarze.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLekarze.Size = new Size(1177, 858);
            dgvLekarze.TabIndex = 0;
            dgvLekarze.SelectionChanged += dgvLekarze_SelectionChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(gbRaportSzczegoly);
            tabPage3.Controls.Add(dgvRaportWizyty);
            tabPage3.Controls.Add(cmbRaportPacjent);
            tabPage3.Controls.Add(label28);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1631, 858);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "Raporty";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // gbRaportSzczegoly
            // 
            gbRaportSzczegoly.Controls.Add(txtRaportDataKontroli);
            gbRaportSzczegoly.Controls.Add(txtRaportKoszt);
            gbRaportSzczegoly.Controls.Add(txtRaportTemperatura);
            gbRaportSzczegoly.Controls.Add(txtRaportWaga);
            gbRaportSzczegoly.Controls.Add(label29);
            gbRaportSzczegoly.Controls.Add(label30);
            gbRaportSzczegoly.Controls.Add(label31);
            gbRaportSzczegoly.Controls.Add(label32);
            gbRaportSzczegoly.Controls.Add(txtRaportLeki);
            gbRaportSzczegoly.Controls.Add(label33);
            gbRaportSzczegoly.Controls.Add(txtRaportZalecenia);
            gbRaportSzczegoly.Controls.Add(label34);
            gbRaportSzczegoly.Controls.Add(txtRaportDiagnoza);
            gbRaportSzczegoly.Controls.Add(label35);
            gbRaportSzczegoly.Controls.Add(txtRaportBadanie);
            gbRaportSzczegoly.Controls.Add(label36);
            gbRaportSzczegoly.Location = new Point(13, 284);
            gbRaportSzczegoly.Name = "gbRaportSzczegoly";
            gbRaportSzczegoly.Size = new Size(1310, 566);
            gbRaportSzczegoly.TabIndex = 3;
            gbRaportSzczegoly.TabStop = false;
            gbRaportSzczegoly.Text = "Szczegóły wybranej wizyty";
            // 
            // txtRaportDataKontroli
            // 
            txtRaportDataKontroli.Location = new Point(156, 533);
            txtRaportDataKontroli.Multiline = true;
            txtRaportDataKontroli.Name = "txtRaportDataKontroli";
            txtRaportDataKontroli.ReadOnly = true;
            txtRaportDataKontroli.Size = new Size(1129, 27);
            txtRaportDataKontroli.TabIndex = 50;
            // 
            // txtRaportKoszt
            // 
            txtRaportKoszt.Location = new Point(156, 500);
            txtRaportKoszt.Multiline = true;
            txtRaportKoszt.Name = "txtRaportKoszt";
            txtRaportKoszt.ReadOnly = true;
            txtRaportKoszt.Size = new Size(1129, 27);
            txtRaportKoszt.TabIndex = 49;
            // 
            // txtRaportTemperatura
            // 
            txtRaportTemperatura.Location = new Point(156, 467);
            txtRaportTemperatura.Multiline = true;
            txtRaportTemperatura.Name = "txtRaportTemperatura";
            txtRaportTemperatura.ReadOnly = true;
            txtRaportTemperatura.Size = new Size(1129, 27);
            txtRaportTemperatura.TabIndex = 48;
            // 
            // txtRaportWaga
            // 
            txtRaportWaga.Location = new Point(156, 434);
            txtRaportWaga.Multiline = true;
            txtRaportWaga.Name = "txtRaportWaga";
            txtRaportWaga.ReadOnly = true;
            txtRaportWaga.Size = new Size(1129, 27);
            txtRaportWaga.TabIndex = 47;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(13, 540);
            label29.Name = "label29";
            label29.Size = new Size(96, 20);
            label29.TabIndex = 44;
            label29.Text = "Data kontroli";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(13, 503);
            label30.Name = "label30";
            label30.Size = new Size(73, 20);
            label30.TabIndex = 42;
            label30.Text = "Koszt (zł):";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(13, 470);
            label31.Name = "label31";
            label31.Size = new Size(125, 20);
            label31.TabIndex = 40;
            label31.Text = "Temperatura (°C):";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(13, 437);
            label32.Name = "label32";
            label32.Size = new Size(80, 20);
            label32.TabIndex = 38;
            label32.Text = "Waga (kg):";
            // 
            // txtRaportLeki
            // 
            txtRaportLeki.Location = new Point(156, 129);
            txtRaportLeki.Multiline = true;
            txtRaportLeki.Name = "txtRaportLeki";
            txtRaportLeki.ReadOnly = true;
            txtRaportLeki.Size = new Size(1129, 148);
            txtRaportLeki.TabIndex = 37;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(13, 283);
            label33.Name = "label33";
            label33.Size = new Size(38, 20);
            label33.TabIndex = 36;
            label33.Text = "Leki:";
            // 
            // txtRaportZalecenia
            // 
            txtRaportZalecenia.Location = new Point(156, 283);
            txtRaportZalecenia.Multiline = true;
            txtRaportZalecenia.Name = "txtRaportZalecenia";
            txtRaportZalecenia.ReadOnly = true;
            txtRaportZalecenia.Size = new Size(1129, 145);
            txtRaportZalecenia.TabIndex = 35;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(13, 129);
            label34.Name = "label34";
            label34.Size = new Size(76, 20);
            label34.TabIndex = 34;
            label34.Text = "Zalecenia:";
            // 
            // txtRaportDiagnoza
            // 
            txtRaportDiagnoza.Location = new Point(156, 75);
            txtRaportDiagnoza.Name = "txtRaportDiagnoza";
            txtRaportDiagnoza.ReadOnly = true;
            txtRaportDiagnoza.Size = new Size(1129, 27);
            txtRaportDiagnoza.TabIndex = 33;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(13, 82);
            label35.Name = "label35";
            label35.Size = new Size(76, 20);
            label35.TabIndex = 32;
            label35.Text = "Diagnoza:";
            // 
            // txtRaportBadanie
            // 
            txtRaportBadanie.Location = new Point(156, 42);
            txtRaportBadanie.Name = "txtRaportBadanie";
            txtRaportBadanie.ReadOnly = true;
            txtRaportBadanie.Size = new Size(1129, 27);
            txtRaportBadanie.TabIndex = 31;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(8, 42);
            label36.Name = "label36";
            label36.Size = new Size(66, 20);
            label36.TabIndex = 30;
            label36.Text = "Badanie:";
            // 
            // dgvRaportWizyty
            // 
            dgvRaportWizyty.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRaportWizyty.Dock = DockStyle.Top;
            dgvRaportWizyty.Location = new Point(0, 0);
            dgvRaportWizyty.Name = "dgvRaportWizyty";
            dgvRaportWizyty.RowHeadersWidth = 51;
            dgvRaportWizyty.Size = new Size(1631, 183);
            dgvRaportWizyty.TabIndex = 2;
            dgvRaportWizyty.SelectionChanged += dgvRaportWizyty_SelectionChanged;
            // 
            // cmbRaportPacjent
            // 
            cmbRaportPacjent.FormattingEnabled = true;
            cmbRaportPacjent.Location = new Point(375, 223);
            cmbRaportPacjent.Name = "cmbRaportPacjent";
            cmbRaportPacjent.Size = new Size(151, 28);
            cmbRaportPacjent.TabIndex = 1;
            cmbRaportPacjent.SelectedIndexChanged += cmbRaportPacjent_SelectedIndexChanged;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(21, 226);
            label28.Name = "label28";
            label28.Size = new Size(348, 20);
            label28.TabIndex = 0;
            label28.Text = "Wybierz pacjenta, aby zobaczyć jego historię wizyt:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1639, 891);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Przychodnia Weterynaryjna";
            Load += Form1_Load;
            gbWizyta.ResumeLayout(false);
            gbWizyta.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numKosztWizyty).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTemperatura).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWaga).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvWizyty).EndInit();
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLekarze).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            gbRaportSzczegoly.ResumeLayout(false);
            gbRaportSzczegoly.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRaportWizyty).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private TabPage gbWizyta;
        private TabPage tabPage1;
        private GroupBox groupBox2;
        private Button btnUsunZwierze;
        private Button btnDodajZwierze;
        private Button btnZapiszZmianyZwierze;
        private TextBox txtRasa;
        private TextBox txtGatunek;
        private TextBox txtImieZwierzecia;
        private DateTimePicker dtpDataUrodzenia;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label6;
        private GroupBox groupBox1;
        private Button btnUsunKlienta;
        private Button btnZapiszZmiany;
        private Label label5;
        private TextBox txtImie;
        private Label label4;
        private TextBox txtNazwisko;
        private Label label3;
        private TextBox txtTelefon;
        private Label label2;
        private TextBox txtEmail;
        private Label label1;
        private TextBox txtAdres;
        private Button btnDodajKlienta;
        private ListBox listBoxZwierzeta;
        private ListBox listBoxKlienci;
        private TabControl tabControl1;
        private DataGridView dgvWizyty;
        private GroupBox groupBox3;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label7;
        private TextBox txtOpisWizyty;
        private DateTimePicker dtpDataWizyty;
        private ComboBox cmbPacjent;
        private ComboBox cmbLekarz;
        private TextBox txtStatusWizyty;
        private Button btnUmowWizyte;
        private Button btnZapiszZmianyWizyta;
        private Button btnUsunWizyte;
        private TabPage tabPage2;
        private GroupBox groupBox4;
        private TextBox txtLekarzSpecjalizacja;
        private TextBox txtLekarzPWZ;
        private TextBox txtLekarzTelefon;
        private TextBox txtLekarzNazwisko;
        private TextBox txtLekarzImie;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private DataGridView dgvLekarze;
        private Button btnZapiszZmianyLekarz;
        private Button btnUsunLekarza;
        private Button btnDodajLekarza;
        private Label label24;
        private TextBox txtLeki;
        private Label label23;
        private TextBox txtZalecenia;
        private Label label22;
        private TextBox txtDiagnoza;
        private Label label21;
        private TextBox txtBadanie;
        private Label label20;
        private NumericUpDown numTemperatura;
        private Label label25;
        private NumericUpDown numWaga;
        private Label label27;
        private NumericUpDown numKosztWizyty;
        private Label label26;
        private DateTimePicker dtpDataKontroli;
        private CheckBox cbZaplanujKontrole;
        private TabPage tabPage3;
        private ComboBox cmbRaportPacjent;
        private Label label28;
        private DataGridView dgvRaportWizyty;
        private GroupBox gbRaportSzczegoly;
        private TextBox txtRaportDataKontroli;
        private TextBox txtRaportKoszt;
        private TextBox txtRaportTemperatura;
        private TextBox txtRaportWaga;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private TextBox txtRaportLeki;
        private Label label33;
        private TextBox txtRaportZalecenia;
        private Label label34;
        private TextBox txtRaportDiagnoza;
        private Label label35;
        private TextBox txtRaportBadanie;
        private Label label36;
    }
}