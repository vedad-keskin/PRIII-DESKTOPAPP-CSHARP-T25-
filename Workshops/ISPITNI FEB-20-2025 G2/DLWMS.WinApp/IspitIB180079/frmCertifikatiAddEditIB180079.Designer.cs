namespace DLWMS.WinApp.IspitIB180079
{
    partial class frmCertifikatiAddEditIB180079
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
            cbStudent = new ComboBox();
            cbGodina = new ComboBox();
            cbCertifikatiGodine = new ComboBox();
            btnSacuvaj = new Button();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Student:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 0;
            label2.Text = "Godina:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 0;
            label3.Text = "Certifikat:";
            // 
            // cbStudent
            // 
            cbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStudent.FormattingEnabled = true;
            cbStudent.Location = new Point(103, 20);
            cbStudent.Name = "cbStudent";
            cbStudent.Size = new Size(409, 28);
            cbStudent.TabIndex = 1;
            // 
            // cbGodina
            // 
            cbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGodina.FormattingEnabled = true;
            cbGodina.Items.AddRange(new object[] { "2025", "2024", "2023", "2022", "2021" });
            cbGodina.Location = new Point(103, 59);
            cbGodina.Name = "cbGodina";
            cbGodina.Size = new Size(409, 28);
            cbGodina.TabIndex = 1;
            cbGodina.SelectedIndexChanged += cbGodina_SelectedIndexChanged;
            // 
            // cbCertifikatiGodine
            // 
            cbCertifikatiGodine.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCertifikatiGodine.FormattingEnabled = true;
            cbCertifikatiGodine.Location = new Point(103, 97);
            cbCertifikatiGodine.Name = "cbCertifikatiGodine";
            cbCertifikatiGodine.Size = new Size(409, 28);
            cbCertifikatiGodine.TabIndex = 1;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(370, 138);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(142, 29);
            btnSacuvaj.TabIndex = 2;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmCertifikatiAddEditIB180079
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 179);
            Controls.Add(btnSacuvaj);
            Controls.Add(cbCertifikatiGodine);
            Controls.Add(cbGodina);
            Controls.Add(cbStudent);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCertifikatiAddEditIB180079";
            Text = "Certifikati";
            Load += frmCertifikatiAddEditIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbStudent;
        private ComboBox cbGodina;
        private ComboBox cbCertifikatiGodine;
        private Button btnSacuvaj;
        private ErrorProvider err;
    }
}