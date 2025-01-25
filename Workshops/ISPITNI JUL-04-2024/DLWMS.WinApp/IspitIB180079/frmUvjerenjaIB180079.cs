using DLWMS.Data;
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
    public partial class frmUvjerenjaIB180079 : Form
    {
        private Student odabraniStudent;
        DLWMSContext db = new DLWMSContext();
        List<StudentiUvjerenjaIB180079> uvjerenja;

        public frmUvjerenjaIB180079(Student odabraniStudent)
        {
            InitializeComponent();
            this.odabraniStudent = odabraniStudent;
        }

        private void frmUvjerenjaIB180079_Load(object sender, EventArgs e)
        {
            dgvUvjerenja.AutoGenerateColumns = false;

            UcitajUvjerenja();

            cbVrsta.SelectedIndex = 0;

        }

        private void UcitajUvjerenja()
        {
            uvjerenja = db.StudentiUvjerenjaIB180079
                .Include(x=> x.Student)
                .Where(x => x.StudentId == odabraniStudent.Id)
                .ToList();

            if (uvjerenja != null)
            {

                dgvUvjerenja.DataSource = null;
                dgvUvjerenja.DataSource = uvjerenja;

            }

            this.Text = $"Broj uvjerenja -> {uvjerenja.Count()}";



            btnGenerisi.Enabled = uvjerenja.Count() != 0 ? true : false;


        }

        private void btnNoviZahtjev_Click(object sender, EventArgs e)
        {
            var frmNovoUvjerenje = new frmNovoUvjerenjeIB180079(odabraniStudent);

            if (frmNovoUvjerenje.ShowDialog() == DialogResult.OK)
            {
                UcitajUvjerenja();
            }
        }

        private void dgvUvjerenja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabranoUvjerenje = uvjerenja[e.RowIndex];

            if (e.ColumnIndex == 5)
            {

                if (MessageBox.Show("Da li ste sigurni da želite izbrisati odabrano uvjerenje ?", "Pitanje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    db.StudentiUvjerenjaIB180079.Remove(odabranoUvjerenje);

                }

            }else if (e.ColumnIndex == 6)
            {
                var frmIzvjestaj = new frmIzvjestaji(odabranoUvjerenje);

                frmIzvjestaj.ShowDialog();

                odabranoUvjerenje.Printano = true;

                db.StudentiUvjerenjaIB180079.Update(odabranoUvjerenje);
               

            }

            db.SaveChanges();
            UcitajUvjerenja();

        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {

            // 1. dio
            // -- validacija
            // -- thread ili await/async
            // -- sve sto je vezano za combo box

            if (ValidirajMultithreading())
            {
                var vrsta = cbVrsta.SelectedItem.ToString();

                await Task.Run(() => GenerisiUvjerenja(vrsta));

                //Thread thread = new Thread(() => GenerisiUvjerenja(vrsta));
                //thread.Start();
            }

        }

        private void GenerisiUvjerenja(string? vrsta)
        {
            // 2. dio
            // -- pohrane
            // -- kalkulacije
            // -- sleep


            var svrha = txtSvrha.Text;

            var broj = int.Parse(txtBroj.Text);

            var info = "";

            for (int i = 0; i < broj; i++)
            {
                Thread.Sleep(300);

                var novoUvjerenje = new StudentiUvjerenjaIB180079()
                {
                    StudentId = odabraniStudent.Id,
                    Vrijeme = DateTime.Now,
                    Vrsta = vrsta,
                    Svrha = svrha,
                    Uplatnica = uvjerenja[0].Uplatnica,
                    Printano = false

                };

                db.StudentiUvjerenjaIB180079.Add(novoUvjerenje);
                db.SaveChanges();

                info += $"{DateTime.Now.ToString("HH:mm:ss")} -> {vrsta} {odabraniStudent} u svrhu {svrha}{Environment.NewLine}";


            }



            Action action = () =>
            {
                // 3. dio
                // -- ucitavanje
                // -- ispisi
                // -- mbox

                MessageBox.Show($"Uspješno je generisano {broj} zahtjeva","Informacija",MessageBoxButtons.OK,MessageBoxIcon.Information);
                UcitajUvjerenja();
                txtInfo.Text = info;

            };
            BeginInvoke(action);
        }

        private bool ValidirajMultithreading()
        {
            return Validator.ProvjeriUnos(txtSvrha, err, Kljucevi.RequiredField)
                &&
                Validator.ProvjeriUnos(txtBroj, err, Kljucevi.RequiredField);
        }
    }
}
