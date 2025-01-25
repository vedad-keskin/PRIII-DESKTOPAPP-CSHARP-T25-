namespace DLWMS.WinApp.IspitIB180079
{
    partial class frmPretragaIB180079
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbSpol = new ComboBox();
            dtpDatumOd = new DateTimePicker();
            dtpDatumDo = new DateTimePicker();
            label4 = new Label();
            cbGrad = new ComboBox();
            txtImePrezime = new TextBox();
            label5 = new Label();
            chbAktivan = new CheckBox();
            dgvStudenti = new DataGridView();
            BrojIndeksa = new DataGridViewTextBoxColumn();
            ImePrezime = new DataGridViewTextBoxColumn();
            Grad = new DataGridViewTextBoxColumn();
            Spol = new DataGridViewTextBoxColumn();
            DatumRodjenja = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Uvjerenja = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "Spol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(372, 9);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 0;
            label2.Text = "rođen u periodu od";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(772, 9);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 0;
            label3.Text = "do";
            // 
            // cbSpol
            // 
            cbSpol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSpol.FormattingEnabled = true;
            cbSpol.Location = new Point(57, 6);
            cbSpol.Name = "cbSpol";
            cbSpol.Size = new Size(309, 28);
            cbSpol.TabIndex = 1;
            cbSpol.SelectedIndexChanged += cbSpol_SelectedIndexChanged;
            // 
            // dtpDatumOd
            // 
            dtpDatumOd.Location = new Point(516, 7);
            dtpDatumOd.Name = "dtpDatumOd";
            dtpDatumOd.Size = new Size(250, 27);
            dtpDatumOd.TabIndex = 2;
            dtpDatumOd.Value = new DateTime(1990, 1, 25, 1, 1, 0, 0);
            dtpDatumOd.ValueChanged += dtpDatumOd_ValueChanged;
            // 
            // dtpDatumDo
            // 
            dtpDatumDo.Location = new Point(805, 6);
            dtpDatumDo.Name = "dtpDatumDo";
            dtpDatumDo.Size = new Size(250, 27);
            dtpDatumDo.TabIndex = 2;
            dtpDatumDo.ValueChanged += dtpDatumDo_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 46);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 3;
            label4.Text = "Grad";
            // 
            // cbGrad
            // 
            cbGrad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrad.FormattingEnabled = true;
            cbGrad.Location = new Point(57, 43);
            cbGrad.Name = "cbGrad";
            cbGrad.Size = new Size(230, 28);
            cbGrad.TabIndex = 1;
            cbGrad.SelectedIndexChanged += cbGrad_SelectedIndexChanged;
            // 
            // txtImePrezime
            // 
            txtImePrezime.Location = new Point(410, 45);
            txtImePrezime.Name = "txtImePrezime";
            txtImePrezime.Size = new Size(539, 27);
            txtImePrezime.TabIndex = 4;
            txtImePrezime.TextChanged += txtImePrezime_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(296, 48);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 0;
            label5.Text = "ime ili prezime";
            // 
            // chbAktivan
            // 
            chbAktivan.AutoSize = true;
            chbAktivan.Checked = true;
            chbAktivan.CheckState = CheckState.Checked;
            chbAktivan.Location = new Point(971, 47);
            chbAktivan.Name = "chbAktivan";
            chbAktivan.Size = new Size(80, 24);
            chbAktivan.TabIndex = 5;
            chbAktivan.Text = "Aktivan";
            chbAktivan.UseVisualStyleBackColor = true;
            chbAktivan.CheckedChanged += chbAktivan_CheckedChanged;
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { BrojIndeksa, ImePrezime, Grad, Spol, DatumRodjenja, Aktivan, Uvjerenja });
            dgvStudenti.Location = new Point(12, 77);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowHeadersWidth = 51;
            dgvStudenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudenti.Size = new Size(1046, 273);
            dgvStudenti.TabIndex = 6;
            dgvStudenti.CellClick += dgvStudenti_CellClick;
            // 
            // BrojIndeksa
            // 
            BrojIndeksa.DataPropertyName = "BrojIndeksa";
            BrojIndeksa.HeaderText = "Broj indeksa";
            BrojIndeksa.MinimumWidth = 6;
            BrojIndeksa.Name = "BrojIndeksa";
            BrojIndeksa.ReadOnly = true;
            BrojIndeksa.Width = 123;
            // 
            // ImePrezime
            // 
            ImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImePrezime.DataPropertyName = "ImePrezime";
            ImePrezime.HeaderText = "Ime i prezime";
            ImePrezime.MinimumWidth = 6;
            ImePrezime.Name = "ImePrezime";
            ImePrezime.ReadOnly = true;
            // 
            // Grad
            // 
            Grad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grad.DataPropertyName = "Grad";
            Grad.HeaderText = "Grad rođenja";
            Grad.MinimumWidth = 6;
            Grad.Name = "Grad";
            Grad.ReadOnly = true;
            // 
            // Spol
            // 
            Spol.DataPropertyName = "Spol";
            Spol.HeaderText = "Spol";
            Spol.MinimumWidth = 6;
            Spol.Name = "Spol";
            Spol.ReadOnly = true;
            Spol.Width = 123;
            // 
            // DatumRodjenja
            // 
            DatumRodjenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumRodjenja.DataPropertyName = "DatumRodjenja";
            DatumRodjenja.HeaderText = "Datum rođenja";
            DatumRodjenja.MinimumWidth = 6;
            DatumRodjenja.Name = "DatumRodjenja";
            DatumRodjenja.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            Aktivan.Width = 123;
            // 
            // Uvjerenja
            // 
            Uvjerenja.HeaderText = "";
            Uvjerenja.MinimumWidth = 6;
            Uvjerenja.Name = "Uvjerenja";
            Uvjerenja.ReadOnly = true;
            Uvjerenja.Text = "Uvjerenja";
            Uvjerenja.UseColumnTextForButtonValue = true;
            Uvjerenja.Width = 125;
            // 
            // frmPretragaIB180079
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 362);
            Controls.Add(dgvStudenti);
            Controls.Add(chbAktivan);
            Controls.Add(txtImePrezime);
            Controls.Add(label4);
            Controls.Add(dtpDatumDo);
            Controls.Add(dtpDatumOd);
            Controls.Add(cbGrad);
            Controls.Add(cbSpol);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPretragaIB180079";
            Text = "Pretraga studenta";
            Load += frmPretragaIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbSpol;
        private DateTimePicker dtpDatumOd;
        private DateTimePicker dtpDatumDo;
        private Label label4;
        private ComboBox cbGrad;
        private TextBox txtImePrezime;
        private Label label5;
        private CheckBox chbAktivan;
        private DataGridView dgvStudenti;
        private DataGridViewTextBoxColumn BrojIndeksa;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn Grad;
        private DataGridViewTextBoxColumn Spol;
        private DataGridViewTextBoxColumn DatumRodjenja;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Uvjerenja;
    }
}