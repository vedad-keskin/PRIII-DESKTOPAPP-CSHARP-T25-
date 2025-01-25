using DLWMS.Data;
using DLWMS.Data.IspitIB180079;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
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
    public partial class frmNovoUvjerenjeIB180079 : Form
    {
        private Student odabraniStudent;
        DLWMSContext db = new DLWMSContext();

        public frmNovoUvjerenjeIB180079(Student odabraniStudent)
        {
            InitializeComponent();
            this.odabraniStudent = odabraniStudent;
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmNovoUvjerenjeIB180079_Load(object sender, EventArgs e)
        {
            cbVrsta.SelectedIndex = 0;

        }

        private void pbUplatnica_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbUplatnica.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {

                var vrsta = cbVrsta.SelectedItem.ToString();

                var svrha = txtSvrha.Text;

                var uplatnica = pbUplatnica.Image.ToByteArray();

                var novoUvjerenje = new StudentiUvjerenjaIB180079()
                {
                    Vrsta = vrsta,
                    Svrha = svrha,
                    Uplatnica = uplatnica,
                    Printano = false,
                    Vrijeme = DateTime.Now,
                    StudentId = odabraniStudent.Id
                };

                db.StudentiUvjerenjaIB180079.Add(novoUvjerenje);
                db.SaveChanges();

                DialogResult = DialogResult.OK;


            }
        }

        private bool Validiraj()
        {
            return Validator.ProvjeriUnos(pbUplatnica, err, Kljucevi.RequiredField)
                &&
                Validator.ProvjeriUnos(txtSvrha, err, Kljucevi.RequiredField)
                ;
        }
    }
}
