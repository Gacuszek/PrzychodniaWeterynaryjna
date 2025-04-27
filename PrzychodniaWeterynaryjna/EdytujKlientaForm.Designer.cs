namespace PrzychodniaWeterynaryjna
{
    partial class EdytujKlientaForm
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
            this.labelImieEdycja = new System.Windows.Forms.Label();
            this.labelNazwiskoEdycja = new System.Windows.Forms.Label();
            this.labelAdresEdycja = new System.Windows.Forms.Label();
            this.labelTelefonEdycja = new System.Windows.Forms.Label();
            this.imieTextBoxEdycja = new System.Windows.Forms.TextBox();
            this.nazwiskoTextBoxEdycja = new System.Windows.Forms.TextBox();
            this.adresTextBoxEdycja = new System.Windows.Forms.TextBox();
            this.telefonTextBoxEdycja = new System.Windows.Forms.TextBox();
            this.zapiszButtonEdycja = new System.Windows.Forms.Button();
            this.anulujButtonEdycja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelImieEdycja
            // 
            this.labelImieEdycja.AutoSize = true;
            this.labelImieEdycja.Location = new System.Drawing.Point(41, 29);
            this.labelImieEdycja.Name = "labelImieEdycja";
            this.labelImieEdycja.Size = new System.Drawing.Size(35, 16);
            this.labelImieEdycja.TabIndex = 0;
            this.labelImieEdycja.Text = "Imię:";
            // 
            // labelNazwiskoEdycja
            // 
            this.labelNazwiskoEdycja.AutoSize = true;
            this.labelNazwiskoEdycja.Location = new System.Drawing.Point(41, 69);
            this.labelNazwiskoEdycja.Name = "labelNazwiskoEdycja";
            this.labelNazwiskoEdycja.Size = new System.Drawing.Size(68, 16);
            this.labelNazwiskoEdycja.TabIndex = 1;
            this.labelNazwiskoEdycja.Text = "Nazwisko:";
            // 
            // labelAdresEdycja
            // 
            this.labelAdresEdycja.AutoSize = true;
            this.labelAdresEdycja.Location = new System.Drawing.Point(41, 115);
            this.labelAdresEdycja.Name = "labelAdresEdycja";
            this.labelAdresEdycja.Size = new System.Drawing.Size(46, 16);
            this.labelAdresEdycja.TabIndex = 2;
            this.labelAdresEdycja.Text = "Adres:";
            // 
            // labelTelefonEdycja
            // 
            this.labelTelefonEdycja.AutoSize = true;
            this.labelTelefonEdycja.Location = new System.Drawing.Point(41, 157);
            this.labelTelefonEdycja.Name = "labelTelefonEdycja";
            this.labelTelefonEdycja.Size = new System.Drawing.Size(56, 16);
            this.labelTelefonEdycja.TabIndex = 3;
            this.labelTelefonEdycja.Text = "Telefon:";
            // 
            // imieTextBoxEdycja
            // 
            this.imieTextBoxEdycja.Location = new System.Drawing.Point(114, 29);
            this.imieTextBoxEdycja.Name = "imieTextBoxEdycja";
            this.imieTextBoxEdycja.Size = new System.Drawing.Size(149, 22);
            this.imieTextBoxEdycja.TabIndex = 4;
            // 
            // nazwiskoTextBoxEdycja
            // 
            this.nazwiskoTextBoxEdycja.Location = new System.Drawing.Point(114, 66);
            this.nazwiskoTextBoxEdycja.Name = "nazwiskoTextBoxEdycja";
            this.nazwiskoTextBoxEdycja.Size = new System.Drawing.Size(149, 22);
            this.nazwiskoTextBoxEdycja.TabIndex = 5;
            // 
            // adresTextBoxEdycja
            // 
            this.adresTextBoxEdycja.Location = new System.Drawing.Point(114, 115);
            this.adresTextBoxEdycja.Name = "adresTextBoxEdycja";
            this.adresTextBoxEdycja.Size = new System.Drawing.Size(149, 22);
            this.adresTextBoxEdycja.TabIndex = 6;
            // 
            // telefonTextBoxEdycja
            // 
            this.telefonTextBoxEdycja.Location = new System.Drawing.Point(114, 154);
            this.telefonTextBoxEdycja.Name = "telefonTextBoxEdycja";
            this.telefonTextBoxEdycja.Size = new System.Drawing.Size(149, 22);
            this.telefonTextBoxEdycja.TabIndex = 7;
            // 
            // zapiszButtonEdycja
            // 
            this.zapiszButtonEdycja.Location = new System.Drawing.Point(222, 238);
            this.zapiszButtonEdycja.Name = "zapiszButtonEdycja";
            this.zapiszButtonEdycja.Size = new System.Drawing.Size(75, 23);
            this.zapiszButtonEdycja.TabIndex = 8;
            this.zapiszButtonEdycja.Text = "Zapisz";
            this.zapiszButtonEdycja.UseVisualStyleBackColor = true;
            this.zapiszButtonEdycja.Click += new System.EventHandler(this.zapiszButtonEdycja_Click);
            // 
            // anulujButtonEdycja
            // 
            this.anulujButtonEdycja.Location = new System.Drawing.Point(222, 295);
            this.anulujButtonEdycja.Name = "anulujButtonEdycja";
            this.anulujButtonEdycja.Size = new System.Drawing.Size(75, 23);
            this.anulujButtonEdycja.TabIndex = 9;
            this.anulujButtonEdycja.Text = "Anuluj";
            this.anulujButtonEdycja.UseVisualStyleBackColor = true;
            this.anulujButtonEdycja.Click += new System.EventHandler(this.anulujButtonEdycja_Click);
            // 
            // EdytujKlientaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.anulujButtonEdycja);
            this.Controls.Add(this.zapiszButtonEdycja);
            this.Controls.Add(this.telefonTextBoxEdycja);
            this.Controls.Add(this.adresTextBoxEdycja);
            this.Controls.Add(this.nazwiskoTextBoxEdycja);
            this.Controls.Add(this.imieTextBoxEdycja);
            this.Controls.Add(this.labelTelefonEdycja);
            this.Controls.Add(this.labelAdresEdycja);
            this.Controls.Add(this.labelNazwiskoEdycja);
            this.Controls.Add(this.labelImieEdycja);
            this.Name = "EdytujKlientaForm";
            this.Text = "EdytujKlientaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelImieEdycja;
        private System.Windows.Forms.Label labelNazwiskoEdycja;
        private System.Windows.Forms.Label labelAdresEdycja;
        private System.Windows.Forms.Label labelTelefonEdycja;
        private System.Windows.Forms.TextBox imieTextBoxEdycja;
        private System.Windows.Forms.TextBox nazwiskoTextBoxEdycja;
        private System.Windows.Forms.TextBox adresTextBoxEdycja;
        private System.Windows.Forms.TextBox telefonTextBoxEdycja;
        private System.Windows.Forms.Button zapiszButtonEdycja;
        private System.Windows.Forms.Button anulujButtonEdycja;
    }
}