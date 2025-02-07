using DLWMS.Data;
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
    public partial class frmStudentEditIB180079 : Form
    {
        private Student odabraniStudent;
        DLWMSContext db = new DLWMSContext();

        public frmStudentEditIB180079(Student odabraniStudent)
        {
            InitializeComponent();
            this.odabraniStudent = odabraniStudent;
        }

        private void frmStudentEditIB180079_Load(object sender, EventArgs e)
        {

            cbDrzava.DataSource = db.Drzave.ToList();

            UcitajInfo();

        }

        private void UcitajInfo()
        {

            pbSlika.Image = odabraniStudent.Slika.ToImage();
            lblImePrezime.Text = $"{odabraniStudent.Ime} {odabraniStudent.Prezime}";
            lblIndeks.Text = odabraniStudent.BrojIndeksa;

            // Selektovanje drzave i grada iz studenta

            cbDrzava.SelectedIndex = odabraniStudent.Grad.DrzavaId - 1;



            // Set the selected city
            cbGrad.SelectedIndex = db.Gradovi.Where(x => x.DrzavaId == odabraniStudent.Grad.DrzavaId).ToList().FindIndex(x => x.Id == odabraniStudent.GradId);

            //for (int i = 0; i < gradoviDrzave.Count(); i++)
            //{

            //    if (odabraniStudent.GradId == gradoviDrzave[i].Id)
            //    {
            //        cbGrad.SelectedIndex = i;
            //    }

            //}


        }
        private void cbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            var odabranaDrzava = cbDrzava.SelectedItem as Drzava;

            cbGrad.DataSource = db.Gradovi
                .Where(x => x.DrzavaId == odabranaDrzava.Id)
                .ToList();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {


                var odabraniGrad = cbGrad.SelectedItem as Grad;

                var slika = pbSlika.Image.ToByteArray();

                odabraniStudent.Slika = slika;
                odabraniStudent.GradId = odabraniGrad.Id;
                odabraniStudent.Grad = odabraniGrad;

                db.Studenti.Update(odabraniStudent);
                db.SaveChanges();

                DialogResult = DialogResult.OK;


            }
        }

        private bool Validiraj()
        {
            return Validator.ProvjeriUnos(pbSlika, err, Kljucevi.RequiredField)
                &&
                Validator.ProvjeriUnos(cbDrzava, err, Kljucevi.RequiredField)
                &&
                Validator.ProvjeriUnos(cbGrad, err, Kljucevi.RequiredField);

        }

        private void btnUcitajSliku_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
