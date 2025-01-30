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
    public partial class frmRazmjeneIB180079 : Form
    {
        private Student odabraniStudent;
        DLWMSContext db = new DLWMSContext();
        List<RazmjeneIB180079> razmjene;
        Drzava odabranaDrzava;

        public frmRazmjeneIB180079(Student odabraniStudent)
        {
            InitializeComponent();
            this.odabraniStudent = odabraniStudent;
        }

        private void cbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            odabranaDrzava = cbDrzava.SelectedItem as Drzava;

            cbUniverzitet.DataSource = db.UniverzitetiIB180079
                .Where(x => x.DrzavaId == odabranaDrzava.Id)
                .ToList();

            UcitajRazmjene();
        }

        private void UcitajRazmjene()
        {

            razmjene = db.RazmjeneIB180079
                .Include(x => x.Univerzitet!.Drzava)
                .Include(x => x.Student)
                .Where(x => x.StudentId == odabraniStudent.Id)
                .Where(x => x.Univerzitet!.DrzavaId == odabranaDrzava!.Id)
                .ToList();

            if (razmjene != null)
            {

                dgvRazmjene.DataSource = null;
                dgvRazmjene.DataSource = razmjene;

            }

        }

        private void frmRazmjeneIB180079_Load(object sender, EventArgs e)
        {

            dgvRazmjene.AutoGenerateColumns = false;

            cbDrzava.DataSource = db.Drzave.ToList();

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {


                var univerzitet = cbUniverzitet.SelectedItem as UniverzitetiIB180079;

                var ects = int.Parse(txtECTS.Text);

                var datumPocetak = dtpPocetak.Value;
                var datumKraj = dtpKraj.Value;

                var okoncana = dtpKraj.Value > DateTime.Now ? false : true;

                if (datumPocetak > datumKraj)
                {
                    MessageBox.Show("Datum početka ne može biti veći od datum kraja", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (razmjene.Exists(x =>
                    (datumPocetak >= x.DatumPocetak && datumPocetak <= x.DatumKraj) || // New start is within an existing range
                    (datumKraj >= x.DatumPocetak && datumKraj <= x.DatumKraj) || // New end is within an existing range
                    (datumPocetak <= x.DatumPocetak && datumKraj >= x.DatumKraj) // New range fully contains an existing range
                 ))
                {
                    MessageBox.Show("Već postoji razmjena u tom vremenskom periodu", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    var novaRazmjena = new RazmjeneIB180079()
                    {
                        StudentId = odabraniStudent.Id,
                        UniverzitetId = univerzitet.Id,
                        DatumPocetak = datumPocetak,
                        DatumKraj = datumKraj,
                        ECTS = ects,
                        Okoncana = okoncana
                    };

                    db.RazmjeneIB180079.Add(novaRazmjena);
                    db.SaveChanges();

                }


                UcitajRazmjene();


            }
        }

        private bool Validiraj()
        {
            return Validator.ProvjeriUnos(cbUniverzitet, err, Kljucevi.RequiredField)
                &&
                Validator.ProvjeriUnos(txtECTS, err, Kljucevi.RequiredField);
        }

        private void dgvRazmjene_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var odabranaRazmjena = razmjene[e.RowIndex];

            if(e.ColumnIndex == 5)
            {

                if(MessageBox.Show($"Da li ste sigurni da želite obrisati podatke o razmjeni {odabraniStudent} na {odabranaRazmjena.Univerzitet}?", "Pitanje", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    db.RazmjeneIB180079.Remove(odabranaRazmjena);
                    db.SaveChanges();

                    UcitajRazmjene();
                }

            }
        }
    }
}
