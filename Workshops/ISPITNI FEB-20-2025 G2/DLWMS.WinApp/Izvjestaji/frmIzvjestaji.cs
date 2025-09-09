using DLWMS.Data.IspitIB180079;
using DLWMS.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using System.Data;

namespace DLWMS.WinApp.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private CertifikatiGodineIB180079? odabraniCertifikatGodina;

        DLWMSContext db = new DLWMSContext();

        //public frmIzvjestaji()
        //{
        //    InitializeComponent();            
        //}

        public frmIzvjestaji(CertifikatiGodineIB180079? odabraniCertifikatGodina)
        {
            InitializeComponent();            
            this.odabraniCertifikatGodina = odabraniCertifikatGodina;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {

            UcitajReport();

            reportViewer1.RefreshReport(); 
        }

        private void UcitajReport()
        {

            var studentCertifikati = db.StudentiCertifikatiIB180079
                .Include(x => x.Student)
                .Include(x => x.CertifikatGodina)
                .Where(x => x.CertifikatGodinaId == odabraniCertifikatGodina.Id)
                .ToList();

            var tblStudentCertifikati = new dsDLWMS.dsStudentiCertifikatiDataTable();


            for (int i = 0; i < studentCertifikati.Count(); i++)
            {

                var Red = tblStudentCertifikati.NewdsStudentiCertifikatiRow();

                Red.Rb = (i + 1).ToString();
                Red.Student = studentCertifikati[i]?.Student?.ToString() ?? "N/A";
                Red.Iznos = odabraniCertifikatGodina?.Iznos.ToString() ?? "0";
                Red.Ukupno = odabraniCertifikatGodina?.UkupnoInfo.ToString() ?? "0";

                tblStudentCertifikati.Rows.Add(Red);

            }

            var rds = new ReportDataSource();

            rds.Value = tblStudentCertifikati;
            rds.Name = "dsStudentCertifikati";

            reportViewer1.LocalReport.DataSources.Add(rds);

            var rpc = new ReportParameterCollection();

            rpc.Add(new ReportParameter("godina", odabraniCertifikatGodina?.Godina ?? "N/A"));
            rpc.Add(new ReportParameter("certifikat", odabraniCertifikatGodina?.ToString() ?? "N/A"));


            var suma = studentCertifikati.Sum(x => x.UkupnoInfo);

            rpc.Add(new ReportParameter("ukupno", suma.ToString()));

            reportViewer1.LocalReport.SetParameters(rpc);


        }
    }
}
