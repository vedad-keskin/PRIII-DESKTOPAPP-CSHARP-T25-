using DLWMS.Data.IspitIB180079;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinApp.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private StudentiUvjerenjaIB180079 odabranoUvjerenje;


        public frmIzvjestaji(StudentiUvjerenjaIB180079 odabranoUvjerenje)
        {
            InitializeComponent();            
            this.odabranoUvjerenje = odabranoUvjerenje;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            IspritnajReport();


            reportViewer1.RefreshReport(); 
        }

        private void IspritnajReport()
        {

            var rpc = new ReportParameterCollection();

            rpc.Add(new ReportParameter("vrsta", odabranoUvjerenje.Vrsta));
            rpc.Add(new ReportParameter("studentInfo", $"{odabranoUvjerenje.Student.Ime} {odabranoUvjerenje.Student.Prezime} ({odabranoUvjerenje.Student.BrojIndeksa})"));
            rpc.Add(new ReportParameter("svrha", odabranoUvjerenje.Svrha));
            rpc.Add(new ReportParameter("status", 
                odabranoUvjerenje.Student.Aktivan ? "AKTIVAN" : "NEAKTIVAN"));

            reportViewer1.LocalReport.SetParameters(rpc);


        }
    }
}
