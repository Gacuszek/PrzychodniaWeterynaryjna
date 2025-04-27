namespace PrzychodniaWeterynaryjna
{
    partial class KlienciForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dodajKlientaButton = new System.Windows.Forms.Button();
            this.edytujKlientaButton = new System.Windows.Forms.Button();
            this.usunKlientaButton = new System.Windows.Forms.Button();
            this.pokazZwierzetaButton = new System.Windows.Forms.Button();
            this.DodajZwierzeForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1300, 348);
            this.dataGridView1.TabIndex = 0;
            // 
            // dodajKlientaButton
            // 
            this.dodajKlientaButton.Location = new System.Drawing.Point(21, 12);
            this.dodajKlientaButton.Name = "dodajKlientaButton";
            this.dodajKlientaButton.Size = new System.Drawing.Size(101, 29);
            this.dodajKlientaButton.TabIndex = 1;
            this.dodajKlientaButton.Text = "Dodaj klienta";
            this.dodajKlientaButton.UseVisualStyleBackColor = true;
            this.dodajKlientaButton.Click += new System.EventHandler(this.dodajKlientaButton_Click);
            // 
            // edytujKlientaButton
            // 
            this.edytujKlientaButton.Location = new System.Drawing.Point(128, 12);
            this.edytujKlientaButton.Name = "edytujKlientaButton";
            this.edytujKlientaButton.Size = new System.Drawing.Size(103, 29);
            this.edytujKlientaButton.TabIndex = 2;
            this.edytujKlientaButton.Text = "Edytuj klienta";
            this.edytujKlientaButton.UseVisualStyleBackColor = true;
            this.edytujKlientaButton.Click += new System.EventHandler(this.edytujKlientaButton_Click);
            // 
            // usunKlientaButton
            // 
            this.usunKlientaButton.Location = new System.Drawing.Point(237, 12);
            this.usunKlientaButton.Name = "usunKlientaButton";
            this.usunKlientaButton.Size = new System.Drawing.Size(101, 29);
            this.usunKlientaButton.TabIndex = 3;
            this.usunKlientaButton.Text = "Usuń klienta";
            this.usunKlientaButton.UseVisualStyleBackColor = true;
            this.usunKlientaButton.Click += new System.EventHandler(this.usunKlientaButton_Click);
            // 
            // pokazZwierzetaButton
            // 
            this.pokazZwierzetaButton.Location = new System.Drawing.Point(344, 12);
            this.pokazZwierzetaButton.Name = "pokazZwierzetaButton";
            this.pokazZwierzetaButton.Size = new System.Drawing.Size(112, 29);
            this.pokazZwierzetaButton.TabIndex = 4;
            this.pokazZwierzetaButton.Text = "Pokaż zwierzęta";
            this.pokazZwierzetaButton.UseVisualStyleBackColor = true;
            this.pokazZwierzetaButton.Click += new System.EventHandler(this.pokazZwierzetaButton_Click);
            // 
            // DodajZwierzeForm
            // 
            this.DodajZwierzeForm.Location = new System.Drawing.Point(462, 12);
            this.DodajZwierzeForm.Name = "DodajZwierzeForm";
            this.DodajZwierzeForm.Size = new System.Drawing.Size(112, 29);
            this.DodajZwierzeForm.TabIndex = 5;
            this.DodajZwierzeForm.Text = "Dodaj zwierzę";
            this.DodajZwierzeForm.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Usuń zwierzę";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // KlienciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 463);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DodajZwierzeForm);
            this.Controls.Add(this.pokazZwierzetaButton);
            this.Controls.Add(this.usunKlientaButton);
            this.Controls.Add(this.edytujKlientaButton);
            this.Controls.Add(this.dodajKlientaButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KlienciForm";
            this.Text = "Klienci";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button dodajKlientaButton;
        private System.Windows.Forms.Button edytujKlientaButton;
        private System.Windows.Forms.Button usunKlientaButton;
        private System.Windows.Forms.Button pokazZwierzetaButton;
        private System.Windows.Forms.Button DodajZwierzeForm;
        private System.Windows.Forms.Button button1;
    }
}