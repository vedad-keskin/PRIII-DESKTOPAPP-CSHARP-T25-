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
    public partial class frmStudentInfoIB180079 : Form
    {
        DLWMSContext db = new DLWMSContext();
        private Student odabraniStudent;

        public frmStudentInfoIB180079(Student odabraniStudent)
        {
            InitializeComponent();
            this.odabraniStudent = odabraniStudent;
        }

        private void frmStudentInfoIB180079_Load(object sender, EventArgs e)
        {
            UcitajInfo();
        }

        private void UcitajInfo()
        {
            pbSlika.Image = odabraniStudent.Slika.ToImage();

            lblImePrezime.Text = odabraniStudent.ImePrezime;

            lblGrad.Text = $"Grad: {odabraniStudent.Grad}";

            this.Text = odabraniStudent.BrojIndeksa;

        }
    }
}
