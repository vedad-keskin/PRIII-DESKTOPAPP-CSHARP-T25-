namespace DLWMS.WinApp.IspitIB180079
{
    partial class frmUvjerenjaIB180079
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
            btnNoviZahtjev = new Button();
            dgvUvjerenja = new DataGridView();
            Vrijeme = new DataGridViewTextBoxColumn();
            Vrsta = new DataGridViewTextBoxColumn();
            Svrha = new DataGridViewTextBoxColumn();
            Uplatnica = new DataGridViewImageColumn();
            Printano = new DataGridViewCheckBoxColumn();
            Brisi = new DataGridViewButtonColumn();
            Printaj = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            cbVrsta = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            err = new ErrorProvider(components);
            txtSvrha = new TextBox();
            txtBroj = new TextBox();
            btnGenerisi = new Button();
            txtInfo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUvjerenja).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // btnNoviZahtjev
            // 
            btnNoviZahtjev.Location = new Point(764, 12);
            btnNoviZahtjev.Name = "btnNoviZahtjev";
            btnNoviZahtjev.Size = new Size(135, 29);
            btnNoviZahtjev.TabIndex = 0;
            btnNoviZahtjev.Text = "Novi zahtjev";
            btnNoviZahtjev.UseVisualStyleBackColor = true;
            btnNoviZahtjev.Click += btnNoviZahtjev_Click;
            // 
            // dgvUvjerenja
            // 
            dgvUvjerenja.AllowUserToAddRows = false;
            dgvUvjerenja.AllowUserToDeleteRows = false;
            dgvUvjerenja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUvjerenja.Columns.AddRange(new DataGridViewColumn[] { Vrijeme, Vrsta, Svrha, Uplatnica, Printano, Brisi, Printaj });
            dgvUvjerenja.Location = new Point(12, 44);
            dgvUvjerenja.Name = "dgvUvjerenja";
            dgvUvjerenja.ReadOnly = true;
            dgvUvjerenja.RowHeadersWidth = 51;
            dgvUvjerenja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUvjerenja.Size = new Size(887, 268);
            dgvUvjerenja.TabIndex = 1;
            dgvUvjerenja.CellContentClick += dgvUvjerenja_CellContentClick;
            // 
            // Vrijeme
            // 
            Vrijeme.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Vrijeme.DataPropertyName = "Vrijeme";
            Vrijeme.HeaderText = "Datum";
            Vrijeme.MinimumWidth = 6;
            Vrijeme.Name = "Vrijeme";
            Vrijeme.ReadOnly = true;
            // 
            // Vrsta
            // 
            Vrsta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Vrsta.DataPropertyName = "Vrsta";
            Vrsta.HeaderText = "Vrsta";
            Vrsta.MinimumWidth = 6;
            Vrsta.Name = "Vrsta";
            Vrsta.ReadOnly = true;
            // 
            // Svrha
            // 
            Svrha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Svrha.DataPropertyName = "Svrha";
            Svrha.HeaderText = "Svrha";
            Svrha.MinimumWidth = 6;
            Svrha.Name = "Svrha";
            Svrha.ReadOnly = true;
            // 
            // Uplatnica
            // 
            Uplatnica.DataPropertyName = "Uplatnica";
            Uplatnica.HeaderText = "Uplatnica";
            Uplatnica.MinimumWidth = 6;
            Uplatnica.Name = "Uplatnica";
            Uplatnica.ReadOnly = true;
            Uplatnica.Width = 125;
            // 
            // Printano
            // 
            Printano.DataPropertyName = "Printano";
            Printano.HeaderText = "Printano";
            Printano.MinimumWidth = 6;
            Printano.Name = "Printano";
            Printano.ReadOnly = true;
            Printano.Width = 125;
            // 
            // Brisi
            // 
            Brisi.HeaderText = "";
            Brisi.MinimumWidth = 6;
            Brisi.Name = "Brisi";
            Brisi.ReadOnly = true;
            Brisi.Text = "Briši";
            Brisi.UseColumnTextForButtonValue = true;
            Brisi.Width = 125;
            // 
            // Printaj
            // 
            Printaj.HeaderText = "";
            Printaj.MinimumWidth = 6;
            Printaj.Name = "Printaj";
            Printaj.ReadOnly = true;
            Printaj.Text = "Printaj";
            Printaj.UseColumnTextForButtonValue = true;
            Printaj.Width = 125;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Controls.Add(txtBroj);
            groupBox1.Controls.Add(txtSvrha);
            groupBox1.Controls.Add(cbVrsta);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 327);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(887, 247);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodavanje zahtjeva za izdavanjem uvjerenja";
            // 
            // cbVrsta
            // 
            cbVrsta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVrsta.FormattingEnabled = true;
            cbVrsta.Items.AddRange(new object[] { "Uvjerenje o položenim ispitima", "Uvjerenje o statusu studenta" });
            cbVrsta.Location = new Point(15, 59);
            cbVrsta.Name = "cbVrsta";
            cbVrsta.Size = new Size(288, 28);
            cbVrsta.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 90);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 0;
            label4.Text = "Info:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(551, 33);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 0;
            label3.Text = "Broj zahtjeva:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 33);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 0;
            label2.Text = "Svrha uvjerenja:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 33);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "Vrsta uvjerenja:";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // txtSvrha
            // 
            txtSvrha.Location = new Point(309, 59);
            txtSvrha.Name = "txtSvrha";
            txtSvrha.Size = new Size(238, 27);
            txtSvrha.TabIndex = 2;
            // 
            // txtBroj
            // 
            txtBroj.Location = new Point(553, 60);
            txtBroj.Name = "txtBroj";
            txtBroj.Size = new Size(199, 27);
            txtBroj.TabIndex = 2;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(758, 58);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(123, 29);
            btnGenerisi.TabIndex = 3;
            btnGenerisi.Text = "Dodaj =>";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(15, 113);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.ScrollBars = ScrollBars.Vertical;
            txtInfo.Size = new Size(856, 128);
            txtInfo.TabIndex = 4;
            // 
            // frmUvjerenjaIB180079
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 574);
            Controls.Add(groupBox1);
            Controls.Add(dgvUvjerenja);
            Controls.Add(btnNoviZahtjev);
            Name = "frmUvjerenjaIB180079";
            Text = "Broj uvjerenja";
            Load += frmUvjerenjaIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUvjerenja).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNoviZahtjev;
        private DataGridView dgvUvjerenja;
        private DataGridViewTextBoxColumn Vrijeme;
        private DataGridViewTextBoxColumn Vrsta;
        private DataGridViewTextBoxColumn Svrha;
        private DataGridViewImageColumn Uplatnica;
        private DataGridViewCheckBoxColumn Printano;
        private DataGridViewButtonColumn Brisi;
        private DataGridViewButtonColumn Printaj;
        private GroupBox groupBox1;
        private ComboBox cbVrsta;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ErrorProvider err;
        private TextBox txtInfo;
        private Button btnGenerisi;
        private TextBox txtBroj;
        private TextBox txtSvrha;
    }
}