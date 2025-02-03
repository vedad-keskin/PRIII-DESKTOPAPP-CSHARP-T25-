using DLWMS.Data;
using DLWMS.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        List<Student> studenti;
        public frmPretragaIB180079()
        {
            InitializeComponent();
        }

        private void cbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void UcitajStudente()
        {


            var spol = cbSpol.SelectedItem as Spol ?? new Spol();

            var grad = cbGrad.SelectedItem as Grad ?? new Grad();

            var datumOd = dtpDatumOd.Value;
            var datumDo = dtpDatumDo.Value;

            var aktivan = chbAktivan.Checked;

            var imePrezime = txtImePrezime.Text.ToLower();

            studenti = db.Studenti
                .Where(x => x.SpolId == spol.Id)
                .Where(x => x.GradId == grad.Id)
                .Where(x => x.DatumRodjenja >= datumOd && x.DatumRodjenja <= datumDo)
                .Where(x => x.Aktivan == aktivan)
                .Where(x => x.Ime.ToLower().StartsWith(imePrezime)
                    || x.Prezime.ToLower().StartsWith(imePrezime)
                   || (x.Ime + " " + x.Prezime).ToLower().StartsWith(imePrezime)

                  )
                .ToList();

            if (studenti != null)
            {

                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = studenti;

            }

            // zakomentarisano radi bržeg testiranja

            //if(studenti.Count() == 0)
            //{
            //    MessageBox.Show($"U bazi podataka ne postoji evidencija o studentima {spol} spola rođenih u periodu od {datumOd} – {datumDo}. godine.");
            //}



        }

        private void frmPretragaIB180079_Load(object sender, EventArgs e)
        {
            dgvStudenti.AutoGenerateColumns = false;

            cbGrad.DataSource = db.Gradovi.ToList();

            cbSpol.DataSource = db.Spolovi.ToList();


        }

        private void dtpDatumOd_ValueChanged(object sender, EventArgs e)
        {
            UcitajStudente();

        }

        private void dtpDatumDo_ValueChanged(object sender, EventArgs e)
        {
            UcitajStudente();

        }

        private void cbGrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void chbAktivan_CheckedChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void txtImePrezime_TextChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void dgvStudenti_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var odabraniStudent = studenti[e.RowIndex];

            if (e.ColumnIndex != 6)
            {

                var frmInfo = new frmStudentInfoIB180079(odabraniStudent);

                frmInfo.ShowDialog();
            }
            else if (e.ColumnIndex == 6)
            {

                var frmUvjerenja = new frmUvjerenjaIB180079(odabraniStudent);

                frmUvjerenja.ShowDialog();
            }


        }

 
    }
}
