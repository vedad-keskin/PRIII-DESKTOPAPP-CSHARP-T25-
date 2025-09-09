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
            cbGodina = new ComboBox();
            cbCertifikat = new ComboBox();
            btnDodaj = new Button();
            btnCertifikati = new Button();
            dgvStudentiCertifikati = new DataGridView();
            Student = new DataGridViewTextBoxColumn();
            GodinaInfo = new DataGridViewTextBoxColumn();
            CertifikatInfo = new DataGridViewTextBoxColumn();
            IznosInfo = new DataGridViewTextBoxColumn();
            UkupnoInfo = new DataGridViewTextBoxColumn();
            Ukloni = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudentiCertifikati).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Godina:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 9);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 0;
            label2.Text = "Certifikat:";
            // 
            // cbGodina
            // 
            cbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGodina.FormattingEnabled = true;
            cbGodina.Items.AddRange(new object[] { "2025", "2024", "2023", "2022", "2021" });
            cbGodina.Location = new Point(12, 32);
            cbGodina.Name = "cbGodina";
            cbGodina.Size = new Size(181, 28);
            cbGodina.TabIndex = 1;
            cbGodina.SelectedIndexChanged += cbGodina_SelectedIndexChanged;
            // 
            // cbCertifikat
            // 
            cbCertifikat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCertifikat.FormattingEnabled = true;
            cbCertifikat.Location = new Point(199, 32);
            cbCertifikat.Name = "cbCertifikat";
            cbCertifikat.Size = new Size(332, 28);
            cbCertifikat.TabIndex = 1;
            cbCertifikat.SelectedIndexChanged += cbCertifikat_SelectedIndexChanged;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(681, 32);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(139, 29);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj certifikat";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnCertifikati
            // 
            btnCertifikati.Location = new Point(826, 32);
            btnCertifikati.Name = "btnCertifikati";
            btnCertifikati.Size = new Size(208, 29);
            btnCertifikati.TabIndex = 2;
            btnCertifikati.Text = "Certifikati po godinama";
            btnCertifikati.UseVisualStyleBackColor = true;
            btnCertifikati.Click += btnCertifikati_Click;
            // 
            // dgvStudentiCertifikati
            // 
            dgvStudentiCertifikati.AllowUserToAddRows = false;
            dgvStudentiCertifikati.AllowUserToDeleteRows = false;
            dgvStudentiCertifikati.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentiCertifikati.Columns.AddRange(new DataGridViewColumn[] { Student, GodinaInfo, CertifikatInfo, IznosInfo, UkupnoInfo, Ukloni });
            dgvStudentiCertifikati.Location = new Point(12, 66);
            dgvStudentiCertifikati.Name = "dgvStudentiCertifikati";
            dgvStudentiCertifikati.ReadOnly = true;
            dgvStudentiCertifikati.RowHeadersWidth = 51;
            dgvStudentiCertifikati.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudentiCertifikati.Size = new Size(1022, 266);
            dgvStudentiCertifikati.TabIndex = 3;
            dgvStudentiCertifikati.CellContentClick += dgvStudentiCertifikati_CellContentClick;
            dgvStudentiCertifikati.CellDoubleClick += dgvStudentiCertifikati_CellDoubleClick;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "(Indeks) Ime i prezime";
            Student.MinimumWidth = 6;
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // GodinaInfo
            // 
            GodinaInfo.DataPropertyName = "GodinaInfo";
            GodinaInfo.HeaderText = "Godina";
            GodinaInfo.MinimumWidth = 6;
            GodinaInfo.Name = "GodinaInfo";
            GodinaInfo.ReadOnly = true;
            GodinaInfo.Width = 125;
            // 
            // CertifikatInfo
            // 
            CertifikatInfo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CertifikatInfo.DataPropertyName = "CertifikatInfo";
            CertifikatInfo.HeaderText = "Certifikat";
            CertifikatInfo.MinimumWidth = 6;
            CertifikatInfo.Name = "CertifikatInfo";
            CertifikatInfo.ReadOnly = true;
            // 
            // IznosInfo
            // 
            IznosInfo.DataPropertyName = "IznosInfo";
            IznosInfo.HeaderText = "Iznos";
            IznosInfo.MinimumWidth = 6;
            IznosInfo.Name = "IznosInfo";
            IznosInfo.ReadOnly = true;
            IznosInfo.Width = 125;
            // 
            // UkupnoInfo
            // 
            UkupnoInfo.DataPropertyName = "UkupnoInfo";
            UkupnoInfo.HeaderText = "Ukupni iznos";
            UkupnoInfo.MinimumWidth = 6;
            UkupnoInfo.Name = "UkupnoInfo";
            UkupnoInfo.ReadOnly = true;
            UkupnoInfo.Width = 125;
            // 
            // Ukloni
            // 
            Ukloni.HeaderText = "";
            Ukloni.MinimumWidth = 6;
            Ukloni.Name = "Ukloni";
            Ukloni.ReadOnly = true;
            Ukloni.Text = "Ukloni";
            Ukloni.UseColumnTextForButtonValue = true;
            Ukloni.Width = 125;
            // 
            // frmPretragaIB180079
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 344);
            Controls.Add(dgvStudentiCertifikati);
            Controls.Add(btnCertifikati);
            Controls.Add(btnDodaj);
            Controls.Add(cbCertifikat);
            Controls.Add(cbGodina);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPretragaIB180079";
            Text = "Broj prikazanih studenata placeholder";
            Load += frmPretragaIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudentiCertifikati).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbGodina;
        private ComboBox cbCertifikat;
        private Button btnDodaj;
        private Button btnCertifikati;
        private DataGridView dgvStudentiCertifikati;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn GodinaInfo;
        private DataGridViewTextBoxColumn CertifikatInfo;
        private DataGridViewTextBoxColumn IznosInfo;
        private DataGridViewTextBoxColumn UkupnoInfo;
        private DataGridViewButtonColumn Ukloni;
    }
}