namespace DLWMS.WinApp.IspitIB180079
{
    partial class frmStudentEditIB180079
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
            pbSlika = new PictureBox();
            btnUcitajSliku = new Button();
            lblImePrezime = new Label();
            lblIndeks = new Label();
            label1 = new Label();
            label2 = new Label();
            cbDrzava = new ComboBox();
            cbGrad = new ComboBox();
            btnSacuvaj = new Button();
            openFileDialog = new OpenFileDialog();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(12, 12);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(347, 307);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            // 
            // btnUcitajSliku
            // 
            btnUcitajSliku.Location = new Point(12, 336);
            btnUcitajSliku.Name = "btnUcitajSliku";
            btnUcitajSliku.Size = new Size(347, 29);
            btnUcitajSliku.TabIndex = 1;
            btnUcitajSliku.Text = "Učitaj sliku";
            btnUcitajSliku.UseVisualStyleBackColor = true;
            btnUcitajSliku.Click += btnUcitajSliku_Click;
            // 
            // lblImePrezime
            // 
            lblImePrezime.AutoSize = true;
            lblImePrezime.Font = new Font("Segoe UI", 25F);
            lblImePrezime.Location = new Point(381, 22);
            lblImePrezime.Name = "lblImePrezime";
            lblImePrezime.Size = new Size(485, 57);
            lblImePrezime.TabIndex = 2;
            lblImePrezime.Text = "Ime prezime placeholder";
            // 
            // lblIndeks
            // 
            lblIndeks.Font = new Font("Segoe UI", 25F);
            lblIndeks.Location = new Point(381, 85);
            lblIndeks.Name = "lblIndeks";
            lblIndeks.Size = new Size(477, 57);
            lblIndeks.TabIndex = 2;
            lblIndeks.Text = "Indeks placeholder";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(381, 183);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 3;
            label1.Text = "Država:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(381, 237);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 3;
            label2.Text = "Grad:";
            // 
            // cbDrzava
            // 
            cbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDrzava.FormattingEnabled = true;
            cbDrzava.Location = new Point(447, 180);
            cbDrzava.Name = "cbDrzava";
            cbDrzava.Size = new Size(402, 28);
            cbDrzava.TabIndex = 4;
            cbDrzava.SelectedIndexChanged += cbDrzava_SelectedIndexChanged;
            // 
            // cbGrad
            // 
            cbGrad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrad.FormattingEnabled = true;
            cbGrad.Location = new Point(447, 234);
            cbGrad.Name = "cbGrad";
            cbGrad.Size = new Size(402, 28);
            cbGrad.TabIndex = 4;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(707, 314);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(142, 29);
            btnSacuvaj.TabIndex = 5;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmStudentEditIB180079
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 377);
            Controls.Add(btnSacuvaj);
            Controls.Add(cbGrad);
            Controls.Add(cbDrzava);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblIndeks);
            Controls.Add(lblImePrezime);
            Controls.Add(btnUcitajSliku);
            Controls.Add(pbSlika);
            Name = "frmStudentEditIB180079";
            Text = "Podaci o studentu";
            Load += frmStudentEditIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private Button btnUcitajSliku;
        private Label lblImePrezime;
        private Label lblIndeks;
        private Label label1;
        private Label label2;
        private ComboBox cbDrzava;
        private ComboBox cbGrad;
        private Button btnSacuvaj;
        private OpenFileDialog openFileDialog;
        private ErrorProvider err;
    }
}