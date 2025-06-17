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
    public partial class frmStipendijaAddEditIB180079 : Form
    {
        private StudentiStipendijeIB180079 odabranaStudentStipendija;
        DLWMSContext db = new DLWMSContext();
        public frmStipendijaAddEditIB180079()
        {
            InitializeComponent();
        }

        public frmStipendijaAddEditIB180079(StudentiStipendijeIB180079 odabranaStudentStipendija)
        {
            InitializeComponent();
            this.odabranaStudentStipendija = odabranaStudentStipendija;
        }

        private void frmStipendijaAddEditIB180079_Load(object sender, EventArgs e)
        {
            UcitajComboBox();
            UcitajInfo();
        }

        private void UcitajComboBox()
        {
            cbStudent.DataSource = db.Studenti.ToList(); // kada se ucitaju studenti oni se boje ako neko edituje ko ima studenta da bi mogao napraviti konfikt jer je student includan u studentiStipendije

        }

        private void UcitajInfo()
        {
            if (odabranaStudentStipendija != null)
            {

                cbStudent.SelectedIndex = db.Studenti.ToList().FindIndex(x => x.Id == odabranaStudentStipendija.StudentId);
                cbStudent.Enabled = false;

                cbGodina.SelectedItem = odabranaStudentStipendija.StipendijaGodina.Godina;

                cbGodina.Enabled = false;

                cbStipendijaGodina.SelectedIndex = db.StipendijeGodineIB180079.ToList().FindIndex(x => x.StipendijaId == odabranaStudentStipendija.StipendijaGodina.StipendijaId);

            }
            else // da bi kod dodavanja automatski se setovala prva godina dok u editu se dodijeli iz stipendije
            {
                cbGodina.SelectedIndex = 0;
            }
        }

        private void cbGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            var godina = cbGodina.SelectedItem.ToString();


            cbStipendijaGodina.DataSource = db.StipendijeGodineIB180079
                .Include(x => x.Stipendija)
                .Where(x => x.Godina == godina)
                .ToList();

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {

            if (Validiraj())
            {

                var student = cbStudent.SelectedItem as Student;
                var stipendijaGodina = cbStipendijaGodina.SelectedItem as StipendijeGodineIB180079;

                // ZA EDIT
                if(odabranaStudentStipendija != null)
                {

                     odabranaStudentStipendija.StipendijaGodinaId = stipendijaGodina.Id;
                     odabranaStudentStipendija.StipendijaGodina = stipendijaGodina;

                     odabranaStudentStipendija.StudentId = student.Id;
                     odabranaStudentStipendija.Student = student;

                     db.StudentiStipendijeIB180079.Update(odabranaStudentStipendija);
                     db.SaveChanges();

                     DialogResult = DialogResult.OK;
             
                }
                else // ZA ADD
                {
                    // Provjera da student već nema stipendiju u odabranoj godini
                    if (db.StudentiStipendijeIB180079.Include(x => x.StipendijaGodina).ToList().Exists(x => x.StipendijaGodina.Godina == stipendijaGodina.Godina && x.StudentId == student.Id))
                    {
                        MessageBox.Show($"Student {student} već ima stipendiju u {stipendijaGodina.Godina} godini.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {

                        var novaStudentStipendija = new StudentiStipendijeIB180079()
                        {
                            StudentId = student.Id,
                            StipendijaGodinaId = stipendijaGodina.Id
                        };

                        db.StudentiStipendijeIB180079.Add(novaStudentStipendija);
                        db.SaveChanges();

                        DialogResult = DialogResult.OK;
                    }


                }

            
            }

        }

        private bool Validiraj()
        {
            return Validator.ProvjeriUnos(cbStipendijaGodina, err, Kljucevi.RequiredField);
        }
    } 
    
}
