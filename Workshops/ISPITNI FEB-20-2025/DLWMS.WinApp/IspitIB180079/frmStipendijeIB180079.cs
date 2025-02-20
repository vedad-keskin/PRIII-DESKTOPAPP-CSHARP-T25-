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
                //var iznos = int.Parse(txtIznos.Text);
                var iznos = int.TryParse(txtIznos.Text, out var result) ? result : 0;

                if(stipendijeGodine.Exists(x => x.Godina == godina && stipendija.Id == x.StipendijaId))
                {
                    MessageBox.Show($"Već postoji {stipendija} stipendija u {godina} godini.","Upozorenje",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
    }
}
