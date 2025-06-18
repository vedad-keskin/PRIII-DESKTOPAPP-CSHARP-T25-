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
    public partial class frmStipendijeIB180079 : Form
    {
        DLWMSContext db = new DLWMSContext();
        List<StipendijeGodineIB180079> stipendijeGodine;
        public frmStipendijeIB180079()
        {
            InitializeComponent();
        }

        private void frmStipendijeIB180079_Load(object sender, EventArgs e)
        {
            dgvStipendijeGodine.AutoGenerateColumns = false;

            UcitajComboBox();

            UcitajStipendijeGodine();

        }

        private void UcitajStipendijeGodine()
        {
            stipendijeGodine = db.StipendijeGodineIB180079
                .Include(x => x.Stipendija)
                .ToList();

            if (stipendijeGodine != null)
            {
                dgvStipendijeGodine.DataSource = null;
                dgvStipendijeGodine.DataSource = stipendijeGodine;
            }

        }

        private void UcitajComboBox()
        {
            cbGodina.SelectedIndex = 0;

            cbStipendija.DataSource = db.StipendijeIB180079.ToList();

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {

                var godina = cbGodina.SelectedItem.ToString();

                var stipendija = cbStipendija.SelectedItem as StipendijeIB180079;

                // Kraći način
                var iznos = int.Parse(txtIznos.Text);
                //var iznos = int.TryParse(txtIznos.Text, out var result) ? result : 0;

                if (stipendijeGodine.Exists(x => x.Godina == godina && stipendija.Id == x.StipendijaId))
                {
                    MessageBox.Show($"Već postoji {stipendija} stipendija u {godina} godini.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    var novaStipendijaGodina = new StipendijeGodineIB180079()
                    {

                        StipendijaId = stipendija.Id,
                        Godina = godina,
                        Iznos = iznos,
                        Aktivan = true

                    };

                    db.StipendijeGodineIB180079.Add(novaStipendijaGodina);
                    db.SaveChanges();

                    UcitajStipendijeGodine();
                }

            }
        }

        private bool Validiraj()
        {
            return Validator.ProvjeriUnos(txtIznos, err, Kljucevi.RequiredField);

        }

        private void frmStipendijeIB180079_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            // 1. dio
            // -- validacija 
            // -- thread ili async/await 
            // -- sve vezano za combo box


            await Task.Run(() => GenerisiStipendije());

            //Thread thread = new Thread(() => GenerisiStipendije(odabranaStipendijaGodina));
            //thread.Start();

        }

        private void GenerisiStipendije()
        {
            // 2. dio
            // -- kalkulacije
            // -- pohrane
            // -- sleep

            var odabranaStipendijaGodina = dgvStipendijeGodine.SelectedRows[0].DataBoundItem as StipendijeGodineIB180079;

            var sviStudenti = db.Studenti.ToList();

            var info = "";

            var redniBroj = 1;

            for (int i = 0; i < sviStudenti.Count(); i++)
            {

                if (!db.StudentiStipendijeIB180079.ToList().Exists(x => x.StipendijaGodina.Godina == odabranaStipendijaGodina!.Godina && x.StudentId == sviStudenti[i].Id))
                {
                    Thread.Sleep(300);

                    var novaStudentiStipendija = new StudentiStipendijeIB180079()
                    {
                        StudentId = sviStudenti[i].Id,
                        StipendijaGodinaId = odabranaStipendijaGodina!.Id
                    };

                    db.StudentiStipendijeIB180079.Add(novaStudentiStipendija);
                    db.SaveChanges();

                    info += $"{redniBroj}. {odabranaStipendijaGodina.Stipendija} stipendija u iznosu od {odabranaStipendijaGodina.Iznos} dodata {sviStudenti[i]}{Environment.NewLine}";

                    redniBroj++;

                }

            }


            Action action = () =>
            {
                // 3. dio
                // -- ucitavanja
                // -- ispisi
                // -- mbox

                if (redniBroj != 1)
                {
                    MessageBox.Show($"Uspješno su generisane stipendije", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show($"Ne postoje stipendije koje zadovoljavaju uslove generisanja", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                txtInfo.Text = info;

            };
            BeginInvoke(action);

        }

        private void dgvStipendijeGodine_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            var odabranaStipendijaGodina = stipendijeGodine[e.RowIndex];

            odabranaStipendijaGodina.Aktivan = !odabranaStipendijaGodina.Aktivan;

            db.StipendijeGodineIB180079.Update(odabranaStipendijaGodina);
            db.SaveChanges();

            UcitajStipendijeGodine();

        }

        private void btnPotvrda_Click(object sender, EventArgs e)
        {

            var odabranaStipendijaGodina = dgvStipendijeGodine.SelectedRows[0].DataBoundItem as StipendijeGodineIB180079;

            var frmIzvjestaj = new frmIzvjestaji(odabranaStipendijaGodina);
            frmIzvjestaj.ShowDialog();  


        }
    }
}
