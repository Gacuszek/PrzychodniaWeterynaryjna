namespace PrzychodniaWeterynaryjna
{
    partial class ZwierzetaForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.WlascicielImieColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WlascicielNazwiskoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WlascicielDataUrodzeniaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GatunekColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImieZwierzeciaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataUrodzeniaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WlascicielImieColumn,
            this.WlascicielNazwiskoColumn,
            this.WlascicielDataUrodzeniaColumn,
            this.GatunekColumn,
            this.ImieZwierzeciaColumn,
            this.DataUrodzeniaColumn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1144, 320);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // WlascicielImieColumn
            // 
            this.WlascicielImieColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WlascicielImieColumn.HeaderText = "Imię właściciela";
            this.WlascicielImieColumn.MinimumWidth = 6;
            this.WlascicielImieColumn.Name = "WlascicielImieColumn";
            this.WlascicielImieColumn.ReadOnly = true;
            // 
            // WlascicielNazwiskoColumn
            // 
            this.WlascicielNazwiskoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WlascicielNazwiskoColumn.HeaderText = "Nazwisko właściciela";
            this.WlascicielNazwiskoColumn.MinimumWidth = 6;
            this.WlascicielNazwiskoColumn.Name = "WlascicielNazwiskoColumn";
            this.WlascicielNazwiskoColumn.ReadOnly = true;
            // 
            // WlascicielDataUrodzeniaColumn
            // 
            this.WlascicielDataUrodzeniaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WlascicielDataUrodzeniaColumn.HeaderText = "Data urodzenia (wl.)";
            this.WlascicielDataUrodzeniaColumn.MinimumWidth = 6;
            this.WlascicielDataUrodzeniaColumn.Name = "WlascicielDataUrodzeniaColumn";
            this.WlascicielDataUrodzeniaColumn.ReadOnly = true;
            // 
            // GatunekColumn
            // 
            this.GatunekColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GatunekColumn.HeaderText = "Gatunek";
            this.GatunekColumn.MinimumWidth = 6;
            this.GatunekColumn.Name = "GatunekColumn";
            this.GatunekColumn.ReadOnly = true;
            // 
            // ImieZwierzeciaColumn
            // 
            this.ImieZwierzeciaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImieZwierzeciaColumn.HeaderText = "Imię zwierzęcia";
            this.ImieZwierzeciaColumn.MinimumWidth = 6;
            this.ImieZwierzeciaColumn.Name = "ImieZwierzeciaColumn";
            this.ImieZwierzeciaColumn.ReadOnly = true;
            // 
            // DataUrodzeniaColumn
            // 
            this.DataUrodzeniaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataUrodzeniaColumn.HeaderText = "Data urodzenia (zw.)";
            this.DataUrodzeniaColumn.MinimumWidth = 6;
            this.DataUrodzeniaColumn.Name = "DataUrodzeniaColumn";
            this.DataUrodzeniaColumn.ReadOnly = true;
            // 
            // ZwierzetaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ZwierzetaForm";
            this.Text = "Zwierzęta";
           // this.Load += new System.EventHandler(this.PacjenciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn WlascicielImieColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WlascicielNazwiskoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WlascicielDataUrodzeniaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GatunekColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImieZwierzeciaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataUrodzeniaColumn;
    }
}