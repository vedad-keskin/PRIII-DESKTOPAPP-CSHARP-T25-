using DLWMS.Data;
using DLWMS.Data.IspitIB180079;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinApp.IspitIB180079
{
    public partial class frmCertifikatiAddEditIB180079 : Form
    {

        DLWMSContext db = new DLWMSContext();
        private StudentiCertifikatiIB180079? odabraniStudentCertifikat;

        public frmCertifikatiAddEditIB180079()
        {
            InitializeComponent();
        }

        public frmCertifikatiAddEditIB180079(StudentiCertifikatiIB180079? odabraniStudentCertifikat)
        {
            InitializeComponent();
            this.odabraniStudentCertifikat = odabraniStudentCertifikat;
        }

        private void frmCertifikatiAddEditIB180079_Load(object sender, EventArgs e)
        {
            UcitajComboBox();

            UcitajInfo();
        }

        private void UcitajInfo()
        {
            if(odabraniStudentCertifikat != null) // editovanje
            {

                 cbStudent.SelectedIndex = db.Studenti.ToList().FindIndex(x => x.Id ==      odabraniStudentCertifikat.StudentId);

                 cbStudent.Enabled = false;

                cbGodina.SelectedItem = odabraniStudentCertifikat.CertifikatGodina.Godina;

                cbCertifikatiGodine.SelectedIndex = db.CertifikatiGodineIB180079.ToList().FindIndex(x => x.CertifikatId == odabraniStudentCertifikat.CertifikatGodina.CertifikatId);

            }

        }

        private void UcitajComboBox()
        {
            cbStudent.DataSource = db.Studenti.ToList();

            cbGodina.SelectedIndex = 0;

        }

        private void cbGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            var godina = cbGodina?.SelectedItem?.ToString() ?? "";

            cbCertifikatiGodine.DataSource = db.CertifikatiGodineIB180079
                .Include(x => x.Certifikat)
                .Where(x => x.Godina == godina)
                .ToList();



        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {

                var student = cbStudent.SelectedItem as Student;

                var certifikatGodina = cbCertifikatiGodine.SelectedItem as CertifikatiGodineIB180079;

                if (db.StudentiCertifikatiIB180079.ToList().Exists(x => x.StudentId == student.Id && x.CertifikatGodinaId == certifikatGodina.Id))
                {
                    MessageBox.Show($"Student {student} već pohađa nastavu {certifikatGodina}", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (odabraniStudentCertifikat != null) // edit
                {

                    var untrackedStudentCertifikat = db.StudentiCertifikatiIB180079.First(x => x.Id == odabraniStudentCertifikat.Id);

                    untrackedStudentCertifikat.CertifikatGodinaId = certifikatGodina.Id;

                    db.StudentiCertifikatiIB180079.Update(untrackedStudentCertifikat);

                }
                else
                {

                    var noviStudentCertifikat = new StudentiCertifikatiIB180079()
                    {

                        StudentId = student.Id,
                        CertifikatGodinaId = certifikatGodina.Id

                    };

                    db.StudentiCertifikatiIB180079.Add(noviStudentCertifikat);

                }

                    db.SaveChanges();

                    DialogResult = DialogResult.OK;


            }
        }

        private bool Validiraj()
        {
            return Validator.ProvjeriUnos(cbCertifikatiGodine, err, Kljucevi.RequiredField);
        }
    }
}
