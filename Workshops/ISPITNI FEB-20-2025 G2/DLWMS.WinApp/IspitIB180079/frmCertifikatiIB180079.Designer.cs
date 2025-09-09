namespace DLWMS.WinApp.IspitIB180079
{
    partial class frmCertifikatiIB180079
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbGodina = new ComboBox();
            cbCertifikat = new ComboBox();
            txtIznos = new TextBox();
            btnDodaj = new Button();
            dgvCertifikatiGodine = new DataGridView();
            Godina = new DataGridViewTextBoxColumn();
            Certifikat = new DataGridViewTextBoxColumn();
            Iznos = new DataGridViewTextBoxColumn();
            UkupnoInfo = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            err = new ErrorProvider(components);
            btnGenerisi = new Button();
            btnIzvjestaj = new Button();
            groupBox1 = new GroupBox();
            txtInfo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCertifikatiGodine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            groupBox1.SuspendLayout();
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
            label2.Location = new Point(186, 9);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 0;
            label2.Text = "Certifikat:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(597, 9);
            label3.Name = "label3";
            label3.Size = new Size(154, 20);
            label3.TabIndex = 0;
            label3.Text = "Mjesečni iznos (BAM):";
            // 
            // cbGodina
            // 
            cbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGodina.FormattingEnabled = true;
            cbGodina.Items.AddRange(new object[] { "2025", "2024", "2023", "2022", "2021" });
            cbGodina.Location = new Point(12, 32);
            cbGodina.Name = "cbGodina";
            cbGodina.Size = new Size(172, 28);
            cbGodina.TabIndex = 1;
            // 
            // cbCertifikat
            // 
            cbCertifikat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCertifikat.FormattingEnabled = true;
            cbCertifikat.Location = new Point(190, 32);
            cbCertifikat.Name = "cbCertifikat";
            cbCertifikat.Size = new Size(400, 28);
            cbCertifikat.TabIndex = 1;
            // 
            // txtIznos
            // 
            txtIznos.Location = new Point(597, 33);
            txtIznos.Name = "txtIznos";
            txtIznos.Size = new Size(177, 27);
            txtIznos.TabIndex = 2;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(780, 33);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(164, 29);
            btnDodaj.TabIndex = 3;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvCertifikatiGodine
            // 
            dgvCertifikatiGodine.AllowUserToAddRows = false;
            dgvCertifikatiGodine.AllowUserToDeleteRows = false;
            dgvCertifikatiGodine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCertifikatiGodine.Columns.AddRange(new DataGridViewColumn[] { Godina, Certifikat, Iznos, UkupnoInfo, Aktivan });
            dgvCertifikatiGodine.Location = new Point(12, 66);
            dgvCertifikatiGodine.Name = "dgvCertifikatiGodine";
            dgvCertifikatiGodine.ReadOnly = true;
            dgvCertifikatiGodine.RowHeadersWidth = 51;
            dgvCertifikatiGodine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCertifikatiGodine.Size = new Size(932, 280);
            dgvCertifikatiGodine.TabIndex = 4;
            dgvCertifikatiGodine.CellDoubleClick += dgvCertifikatiGodine_CellDoubleClick;
            // 
            // Godina
            // 
            Godina.DataPropertyName = "Godina";
            Godina.HeaderText = "Godina";
            Godina.MinimumWidth = 6;
            Godina.Name = "Godina";
            Godina.ReadOnly = true;
            Godina.Width = 125;
            // 
            // Certifikat
            // 
            Certifikat.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Certifikat.DataPropertyName = "Certifikat";
            Certifikat.HeaderText = "Certifikat";
            Certifikat.MinimumWidth = 6;
            Certifikat.Name = "Certifikat";
            Certifikat.ReadOnly = true;
            // 
            // Iznos
            // 
            Iznos.DataPropertyName = "Iznos";
            Iznos.HeaderText = "Mjesečni iznos";
            Iznos.MinimumWidth = 6;
            Iznos.Name = "Iznos";
            Iznos.ReadOnly = true;
            Iznos.Width = 150;
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
            // Aktivan
            // 
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            Aktivan.Width = 125;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(12, 352);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(203, 29);
            btnGenerisi.TabIndex = 5;
            btnGenerisi.Text = "Generiši certifikate >>>>>";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // btnIzvjestaj
            // 
            btnIzvjestaj.Location = new Point(780, 352);
            btnIzvjestaj.Name = "btnIzvjestaj";
            btnIzvjestaj.Size = new Size(164, 29);
            btnIzvjestaj.TabIndex = 5;
            btnIzvjestaj.Text = "Izvještaj";
            btnIzvjestaj.UseVisualStyleBackColor = true;
            btnIzvjestaj.Click += btnIzvjestaj_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Location = new Point(12, 387);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(932, 207);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator info";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(6, 26);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.ScrollBars = ScrollBars.Vertical;
            txtInfo.Size = new Size(920, 175);
            txtInfo.TabIndex = 0;
            // 
            // frmCertifikatiIB180079
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 606);
            Controls.Add(groupBox1);
            Controls.Add(btnIzvjestaj);
            Controls.Add(btnGenerisi);
            Controls.Add(dgvCertifikatiGodine);
            Controls.Add(btnDodaj);
            Controls.Add(txtIznos);
            Controls.Add(cbCertifikat);
            Controls.Add(cbGodina);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCertifikatiIB180079";
            Text = "Upravljanje certifikatima";
            FormClosed += frmCertifikatiIB180079_FormClosed;
            Load += frmCertifikatiIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCertifikatiGodine).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbGodina;
        private ComboBox cbCertifikat;
        private TextBox txtIznos;
        private Button btnDodaj;
        private DataGridView dgvCertifikatiGodine;
        private DataGridViewTextBoxColumn Godina;
        private DataGridViewTextBoxColumn Certifikat;
        private DataGridViewTextBoxColumn Iznos;
        private DataGridViewTextBoxColumn UkupnoInfo;
        private DataGridViewCheckBoxColumn Aktivan;
        private ErrorProvider err;
        private GroupBox groupBox1;
        private TextBox txtInfo;
        private Button btnIzvjestaj;
        private Button btnGenerisi;
    }
}