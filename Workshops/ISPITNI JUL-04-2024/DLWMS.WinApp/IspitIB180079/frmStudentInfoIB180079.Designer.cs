namespace DLWMS.WinApp.IspitIB180079
{
    partial class frmStudentInfoIB180079
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
            pbSlika = new PictureBox();
            lblImePrezime = new Label();
            lblGrad = new Label();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(43, 22);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(269, 242);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            // 
            // lblImePrezime
            // 
            lblImePrezime.Font = new Font("Segoe UI", 15F);
            lblImePrezime.Location = new Point(43, 267);
            lblImePrezime.Name = "lblImePrezime";
            lblImePrezime.Size = new Size(269, 43);
            lblImePrezime.TabIndex = 1;
            lblImePrezime.Text = "Ime i prezime";
            lblImePrezime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrad
            // 
            lblGrad.Font = new Font("Segoe UI", 10F);
            lblGrad.Location = new Point(43, 310);
            lblGrad.Name = "lblGrad";
            lblGrad.Size = new Size(269, 33);
            lblGrad.TabIndex = 1;
            lblGrad.Text = "Grad:";
            lblGrad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmStudentInfoIB180079
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 353);
            Controls.Add(lblGrad);
            Controls.Add(lblImePrezime);
            Controls.Add(pbSlika);
            Name = "frmStudentInfoIB180079";
            Text = "Indeks";
            Load += frmStudentInfoIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbSlika;
        private Label lblImePrezime;
        private Label lblGrad;
    }
}