using DLWMS.Data.IspitIB180079;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
using DLWMS.WinApp.Izvjestaji;
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
    public partial class frmCertifikatiIB180079 : Form
    {
        DLWMSContext db = new DLWMSContext();
        List<CertifikatiGodineIB180079> certifikatiGodine;
        public frmCertifikatiIB180079()
        {
            InitializeComponent();
        }

        private void frmCertifikatiIB180079_Load(object sender, EventArgs e)
        {
            dgvCertifikatiGodine.AutoGenerateColumns = false;

            UcitajComboBox();
            UcitajCertifikateGodine();
        }

        private void UcitajComboBox()
        {
            cbGodina.SelectedIndex = 0;

            cbCertifikat.DataSource = db.CertifikatiIB180079.ToList();
        }

        private void UcitajCertifikateGodine()
        {

            certifikatiGodine = db.CertifikatiGodineIB180079
                .Include(x => x.Certifikat)
                .ToList();


            if (certifikatiGodine != null)
            {

                dgvCertifikatiGodine.DataSource = null;
                dgvCertifikatiGodine.DataSource = certifikatiGodine;

            }

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            if (Validiraj())
            {

                var iznos = int.Parse(txtIznos.Text);

                var godina = cbGodina.SelectedItem.ToString();

                var certifikat = cbCertifikat.SelectedItem as CertifikatiIB180079;

                if (certifikatiGodine.Exists(x => x.CertifikatId == certifikat.Id && x.Godina == godina))
                {
                    MessageBox.Show($"Odabrana {certifikat} je već evidentiran na {godina} godini", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    var novaCertifikatGodina = new CertifikatiGodineIB180079()
                    {
                        CertifikatId = certifikat.Id,
                        Iznos = iznos,
                        Godina = godina,
                        Aktivan = true

                    };

                    db.CertifikatiGodineIB180079.Add(novaCertifikatGodina);
                    db.SaveChanges();

                    UcitajCertifikateGodine();

                    txtIznos.Clear();

                }



            }

        }

        private bool Validiraj()
        {
            return Validator.ProvjeriUnos(txtIznos, err, Kljucevi.RequiredField);
        }

        private void dgvCertifikatiGodine_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            //var odabraniCertifikatGodina = certifikatiGodine[e.RowIndex];
            var odabraniCertifikatGodina = dgvCertifikatiGodine.SelectedRows[0].DataBoundItem as CertifikatiGodineIB180079;

            odabraniCertifikatGodina.Aktivan = !odabraniCertifikatGodina.Aktivan;

            db.CertifikatiGodineIB180079.Update(odabraniCertifikatGodina);
            db.SaveChanges();

            UcitajCertifikateGodine();


        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            // 1. dio 
            // validacija
            // thread -- await/async/Task
            // sve vezano za combo box

            //Thread thread = new Thread(() => GenerisiCertifikate());
            //thread.Start();

            await Task.Run(() => GenerisiCertifikate());


        }

        private void GenerisiCertifikate()
        {

            // 2. dio
            // pohrane
            // kalkulacije
            // sleep

            var odabraniCertifikatGodina = dgvCertifikatiGodine.SelectedRows[0].DataBoundItem as CertifikatiGodineIB180079;

            var sviStudenti = db.Studenti.ToList();

            var info = "";

            var redniBroj = 0;


            for (int i = 0; i < sviStudenti.Count(); i++)
            {

                if (!db.StudentiCertifikatiIB180079.ToList().Exists(x => x.CertifikatGodinaId == odabraniCertifikatGodina.Id && x.StudentId == sviStudenti[i].Id))
                {

                    var noviStudentCertifikat = new StudentiCertifikatiIB180079()
                    {

                        StudentId = sviStudenti[i].Id,
                        CertifikatGodinaId = odabraniCertifikatGodina.Id

                    };

                    db.StudentiCertifikatiIB180079.Add(noviStudentCertifikat);
                    db.SaveChanges();

                    redniBroj++;

                    info += $"{redniBroj}. {odabraniCertifikatGodina} po mjesečnoj cijeni {odabraniCertifikatGodina.Iznos} dodijeljen {sviStudenti[i]}{Environment.NewLine}";

                    Thread.Sleep(300);

                }

            }




            Action action = () =>
            {

                // 3. dio
                // mbox
                // ucitavanje
                // info

                MessageBox.Show("Uspješno su generisani certifikati", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtInfo.Text = info;


            };
            BeginInvoke(action);


        }

        private void frmCertifikatiIB180079_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            var odabraniCertifikatGodina = dgvCertifikatiGodine.SelectedRows[0].DataBoundItem as CertifikatiGodineIB180079;

            var frmIzvjestaj = new frmIzvjestaji(odabraniCertifikatGodina);

            frmIzvjestaj.ShowDialog();

        }
    }
}
