using DLWMS.Data.IspitIB180079;
using DLWMS.Infrastructure;
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
            cbStudent.DataSource = db.Studenti.ToList();
        }

        private void UcitajInfo()
        {
            if(odabranaStudentStipendija != null)
            {
                cbStudent.SelectedIndex = db.Studenti.ToList().FindIndex(x => x.Id == odabranaStudentStipendija.StudentId);
                cbStudent.Enabled = false;

                cbGodina.SelectedItem = odabranaStudentStipendija.StipendijaGodina.Godina;


            }
        }
    }
}
