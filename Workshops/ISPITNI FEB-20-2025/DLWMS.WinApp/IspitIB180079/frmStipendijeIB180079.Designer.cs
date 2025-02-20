namespace DLWMS.WinApp.IspitIB180079
{
    partial class frmStipendijeIB180079
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
            cbStipendija = new ComboBox();
            txtIznos = new TextBox();
            btnDodaj = new Button();
            dgvStipendijeGodine = new DataGridView();
            Godina = new DataGridViewTextBoxColumn();
            Stipendija = new DataGridViewTextBoxColumn();
            Iznos = new DataGridViewTextBoxColumn();
            Ukupno = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvStipendijeGodine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Godina:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 18);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 0;
            label2.Text = "Stipendija:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(528, 18);
            label3.Name = "label3";
            label3.Size = new Size(154, 20);
            label3.TabIndex = 0;
            label3.Text = "Mjesečni iznos (BAM):";
            // 
            // cbGodina
            // 
            cbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGodina.FormattingEnabled = true;
            cbGodina.Items.AddRange(new object[] { "2025", "2024", "2023", "2022", "2021", "2020", "2019", "2018" });
            cbGodina.Location = new Point(12, 41);
            cbGodina.Name = "cbGodina";
            cbGodina.Size = new Size(250, 28);
            cbGodina.TabIndex = 1;
            // 
            // cbStipendija
            // 
            cbStipendija.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStipendija.FormattingEnabled = true;
            cbStipendija.Location = new Point(270, 41);
            cbStipendija.Name = "cbStipendija";
            cbStipendija.Size = new Size(250, 28);
            cbStipendija.TabIndex = 1;
            // 
            // txtIznos
            // 
            txtIznos.Location = new Point(528, 42);
            txtIznos.Name = "txtIznos";
            txtIznos.Size = new Size(229, 27);
            txtIznos.TabIndex = 2;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(763, 42);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(135, 29);
            btnDodaj.TabIndex = 3;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvStipendijeGodine
            // 
            dgvStipendijeGodine.AllowUserToAddRows = false;
            dgvStipendijeGodine.AllowUserToDeleteRows = false;
            dgvStipendijeGodine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStipendijeGodine.Columns.AddRange(new DataGridViewColumn[] { Godina, Stipendija, Iznos, Ukupno, Aktivan });
            dgvStipendijeGodine.Location = new Point(12, 75);
            dgvStipendijeGodine.Name = "dgvStipendijeGodine";
            dgvStipendijeGodine.ReadOnly = true;
            dgvStipendijeGodine.RowHeadersWidth = 51;
            dgvStipendijeGodine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStipendijeGodine.Size = new Size(1052, 260);
            dgvStipendijeGodine.TabIndex = 4;
            // 
            // Godina
            // 
            Godina.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Godina.DataPropertyName = "Godina";
            Godina.HeaderText = "Godina";
            Godina.MinimumWidth = 6;
            Godina.Name = "Godina";
            Godina.ReadOnly = true;
            // 
            // Stipendija
            // 
            Stipendija.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Stipendija.DataPropertyName = "Stipendija";
            Stipendija.HeaderText = "Stipendija";
            Stipendija.MinimumWidth = 6;
            Stipendija.Name = "Stipendija";
            Stipendija.ReadOnly = true;
            // 
            // Iznos
            // 
            Iznos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Iznos.DataPropertyName = "Iznos";
            Iznos.HeaderText = "Mjesečni iznos";
            Iznos.MinimumWidth = 6;
            Iznos.Name = "Iznos";
            Iznos.ReadOnly = true;
            // 
            // Ukupno
            // 
            Ukupno.DataPropertyName = "Ukupno";
            Ukupno.HeaderText = "Ukupni iznos";
            Ukupno.MinimumWidth = 6;
            Ukupno.Name = "Ukupno";
            Ukupno.ReadOnly = true;
            Ukupno.Width = 125;
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
            // frmStipendijeIB180079
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 350);
            Controls.Add(dgvStipendijeGodine);
            Controls.Add(btnDodaj);
            Controls.Add(txtIznos);
            Controls.Add(cbStipendija);
            Controls.Add(cbGodina);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmStipendijeIB180079";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upravljanje stipendijama";
            Load += frmStipendijeIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStipendijeGodine).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbGodina;
        private ComboBox cbStipendija;
        private TextBox txtIznos;
        private Button btnDodaj;
        private DataGridView dgvStipendijeGodine;
        private DataGridViewTextBoxColumn Godina;
        private DataGridViewTextBoxColumn Stipendija;
        private DataGridViewTextBoxColumn Iznos;
        private DataGridViewTextBoxColumn Ukupno;
        private DataGridViewCheckBoxColumn Aktivan;
        private ErrorProvider err;
    }
}