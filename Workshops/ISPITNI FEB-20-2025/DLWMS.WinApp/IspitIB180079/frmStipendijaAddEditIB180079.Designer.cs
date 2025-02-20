namespace DLWMS.WinApp.IspitIB180079
{
    partial class frmStipendijaAddEditIB180079
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
            cbStudent = new ComboBox();
            cbGodina = new ComboBox();
            cbStipendija = new ComboBox();
            btnSacuvaj = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 75);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Godina:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 121);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 0;
            label2.Text = "Stipendija:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 29);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 0;
            label3.Text = "Student:";
            // 
            // cbStudent
            // 
            cbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStudent.FormattingEnabled = true;
            cbStudent.Location = new Point(129, 26);
            cbStudent.Name = "cbStudent";
            cbStudent.Size = new Size(377, 28);
            cbStudent.TabIndex = 1;
            // 
            // cbGodina
            // 
            cbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGodina.FormattingEnabled = true;
            cbGodina.Items.AddRange(new object[] { "2025", "2024", "2023", "2022", "2021", "2020", "2019", "2018" });
            cbGodina.Location = new Point(129, 72);
            cbGodina.Name = "cbGodina";
            cbGodina.Size = new Size(377, 28);
            cbGodina.TabIndex = 1;
            // 
            // cbStipendija
            // 
            cbStipendija.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStipendija.FormattingEnabled = true;
            cbStipendija.Location = new Point(129, 118);
            cbStipendija.Name = "cbStipendija";
            cbStipendija.Size = new Size(377, 28);
            cbStipendija.TabIndex = 1;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(379, 163);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(127, 29);
            btnSacuvaj.TabIndex = 2;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // frmStipendijaAddEditIB180079
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 204);
            Controls.Add(btnSacuvaj);
            Controls.Add(cbStipendija);
            Controls.Add(cbGodina);
            Controls.Add(cbStudent);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmStipendijaAddEditIB180079";
            Text = "Dodjela stipendije";
            Load += frmStipendijaAddEditIB180079_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbStudent;
        private ComboBox cbGodina;
        private ComboBox cbStipendija;
        private Button btnSacuvaj;
    }
}