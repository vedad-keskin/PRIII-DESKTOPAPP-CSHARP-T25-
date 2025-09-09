using DLWMS.Data.IspitIB180079;
using DLWMS.Infrastructure;
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
    public partial class frmPretragaIB180079 : Form
    {
        DLWMSContext db = new DLWMSContext();
        List<StudentiCertifikatiIB180079> studentiCertifikati;
        public frmPretragaIB180079()
        {
            InitializeComponent();
        }

        private void frmPretragaIB180079_Load(object sender, EventArgs e)
        {
            dgvStudentiCertifikati.AutoGenerateColumns = false;

            UcitajComboBox();

        }

        private void UcitajComboBox()
        {
            cbCertifikat.DataSource = db.CertifikatiIB180079.ToList();

            cbGodina.SelectedIndex = 0;

        }

        private void cbGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudentiCertifikati();
        }

        private void UcitajStudentiCertifikati()
        {

            var godina = cbGodina?.SelectedItem?.ToString() ?? ""; // "2025"

            var certifikat = cbCertifikat?.SelectedItem as CertifikatiIB180079 ?? new CertifikatiIB180079();

            studentiCertifikati = db.StudentiCertifikatiIB180079
                .Include(x => x.CertifikatGodina.Certifikat)
                .Include(x => x.Student)
                .Where(x => x.CertifikatGodina.Godina == godina)
                .Where(x => x.CertifikatGodina.CertifikatId == certifikat.Id)
                .ToList();

            if (studentiCertifikati != null)
            {

                dgvStudentiCertifikati.DataSource = null;
                dgvStudentiCertifikati.DataSource = studentiCertifikati;

            }

            Text = $"Broj prikazanih zapisa: {studentiCertifikati.Count()}";


            if (studentiCertifikati.Count() == 0 && godina != "" && certifikat.Id != 0)
            {

                MessageBox.Show($"U bazi nisu evidentirani studenti kojima je u {godina}. pohađao nastavu za stjecanje certifikata {certifikat}", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void cbCertifikat_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudentiCertifikati();
        }

        private void dgvStudentiCertifikati_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {

                if (MessageBox.Show("Da li ste sigurni da želite izbrisati odabrani certifikat ?", "Pitanje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    //var odabraniStudentCertifikat = studentiCertifikati[e.RowIndex];
                    var odabraniStudentCertifikat = dgvStudentiCertifikati.SelectedRows[0].DataBoundItem as StudentiCertifikatiIB180079;

                    db.StudentiCertifikatiIB180079.Remove(odabraniStudentCertifikat);
                    db.SaveChanges();

                    UcitajStudentiCertifikati();


                }

            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            var frmAddCertifikat = new frmCertifikatiAddEditIB180079();

            if (frmAddCertifikat.ShowDialog() == DialogResult.OK)
            {
                UcitajStudentiCertifikati();
            }

        }

        private void dgvStudentiCertifikati_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 5)
            {

                //var odabraniStudentCertifikat = studentiCertifikati[e.RowIndex];
                var odabraniStudentCertifikat = dgvStudentiCertifikati.SelectedRows[0].DataBoundItem as StudentiCertifikatiIB180079;

                var frmEditCertifikat = new frmCertifikatiAddEditIB180079(odabraniStudentCertifikat);

                if (frmEditCertifikat.ShowDialog() == DialogResult.OK)
                {
                    UcitajStudentiCertifikati();
                }

            }

        }

        private void btnCertifikati_Click(object sender, EventArgs e)
        {
            var frmCertifikati = new frmCertifikatiIB180079();

            if (frmCertifikati.ShowDialog() == DialogResult.OK)
            {
                UcitajStudentiCertifikati();
            }

        }
    }
}
