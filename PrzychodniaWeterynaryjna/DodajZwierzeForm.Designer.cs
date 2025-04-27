namespace PrzychodniaWeterynaryjna
{
    partial class DodajZwierzeForm
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
            this.imieZwierzeciaLabel = new System.Windows.Forms.Label();
            this.gatunekLabel = new System.Windows.Forms.Label();
            this.dataUrodzeniaLabel = new System.Windows.Forms.Label();
            this.imieZwierzeciaTextBox = new System.Windows.Forms.TextBox();
            this.gatunekTextBox = new System.Windows.Forms.TextBox();
            this.dataUrodzeniaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.zapiszButton = new System.Windows.Forms.Button();
            this.anulujButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label(); // Zakładam, że to jest ta problematyczna etykieta
            this.SuspendLayout();
            //
            // imieZwierzeciaLabel
            //
            this.imieZwierzeciaLabel.AutoSize = true;
            this.imieZwierzeciaLabel.Location = new System.Drawing.Point(12, 9);
            this.imieZwierzeciaLabel.Name = "imieZwierzeciaLabel";
            this.imieZwierzeciaLabel.Size = new System.Drawing.Size(80, 13);
            this.imieZwierzeciaLabel.TabIndex = 0;
            this.imieZwierzeciaLabel.Text = "Imię zwierzęcia:";
            //
            // gatunekLabel
            //
            this.gatunekLabel.AutoSize = true;
            this.gatunekLabel.Location = new System.Drawing.Point(12, 38);
            this.gatunekLabel.Name = "gatunekLabel";
            this.gatunekLabel.Size = new System.Drawing.Size(49, 13);
            this.gatunekLabel.TabIndex = 1;
            this.gatunekLabel.Text = "Gatunek:";
            //
            // dataUrodzeniaLabel
            //
            this.dataUrodzeniaLabel.AutoSize = true;
            this.dataUrodzeniaLabel.Location = new System.Drawing.Point(12, 67);
            this.dataUrodzeniaLabel.Name = "dataUrodzeniaLabel";
            this.dataUrodzeniaLabel.Size = new System.Drawing.Size(82, 13);
            this.dataUrodzeniaLabel.TabIndex = 2;
            this.dataUrodzeniaLabel.Text = "Data urodzenia:";
            //
            // imieZwierzeciaTextBox
            //
            this.imieZwierzeciaTextBox.Location = new System.Drawing.Point(111, 6);
            this.imieZwierzeciaTextBox.Name = "imieZwierzeciaTextBox";
            this.imieZwierzeciaTextBox.Size = new System.Drawing.Size(200, 20);
            this.imieZwierzeciaTextBox.TabIndex = 3;
            //
            // gatunekTextBox
            //
            this.gatunekTextBox.Location = new System.Drawing.Point(111, 35);
            this.gatunekTextBox.Name = "gatunekTextBox";
            this.gatunekTextBox.Size = new System.Drawing.Size(200, 20);
            this.gatunekTextBox.TabIndex = 4;
            //
            // dataUrodzeniaDateTimePicker
            //
            this.dataUrodzeniaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataUrodzeniaDateTimePicker.Location = new System.Drawing.Point(111, 64);
            this.dataUrodzeniaDateTimePicker.Name = "dataUrodzeniaDateTimePicker";
            this.dataUrodzeniaDateTimePicker.Size = new System.Drawing.Size(110, 20);
            this.dataUrodzeniaDateTimePicker.TabIndex = 5;
            //
            // zapiszButton
            //
            this.zapiszButton.Location = new System.Drawing.Point(155, 125);
            this.zapiszButton.Name = "zapiszButton";
            this.zapiszButton.Size = new System.Drawing.Size(75, 23);
            this.zapiszButton.TabIndex = 6;
            this.zapiszButton.Text = "Zapisz";
            this.zapiszButton.UseVisualStyleBackColor = true;
            this.zapiszButton.Click += new System.EventHandler(this.zapiszButton_Click);
            //
            // anulujButton
            //
            this.anulujButton.Location = new System.Drawing.Point(236, 125);
            this.anulujButton.Name = "anulujButton";
            this.anulujButton.Size = new System.Drawing.Size(75, 23);
            this.anulujButton.TabIndex = 7;
            this.anulujButton.Text = "Anuluj";
            this.anulujButton.UseVisualStyleBackColor = true;
            this.anulujButton.Click += new System.EventHandler(this.anulujButton_Click);
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            //
            // DodajZwierzeForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 160);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.anulujButton);
            this.Controls.Add(this.zapiszButton);
            this.Controls.Add(this.dataUrodzeniaDateTimePicker);
            this.Controls.Add(this.gatunekTextBox);
            this.Controls.Add(this.imieZwierzeciaTextBox);
            this.Controls.Add(this.dataUrodzeniaLabel);
            this.Controls.Add(this.gatunekLabel);
            this.Controls.Add(this.imieZwierzeciaLabel);
            this.Name = "DodajZwierzeForm";
            this.Text = "Dodaj zwierzę";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imieZwierzeciaLabel;
        private System.Windows.Forms.Label gatunekLabel;
        private System.Windows.Forms.Label dataUrodzeniaLabel;
        private System.Windows.Forms.TextBox imieZwierzeciaTextBox;
        private System.Windows.Forms.TextBox gatunekTextBox;
        private System.Windows.Forms.DateTimePicker dataUrodzeniaDateTimePicker;
        private System.Windows.Forms.Button zapiszButton;
        private System.Windows.Forms.Button anulujButton;
        private System.Windows.Forms.Label label1; // Deklaracja etykiety
    }
}