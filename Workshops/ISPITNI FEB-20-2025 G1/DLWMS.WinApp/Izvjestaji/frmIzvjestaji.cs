using DLWMS.Data.IspitIB180079;
using DLWMS.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinApp.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private StipendijeGodineIB180079? odabranaStipendijaGodina;
        DLWMSContext db = new DLWMSContext();

        public frmIzvjestaji(StipendijeGodineIB180079? odabranaStipendijaGodina)
        {
            InitializeComponent();            
            this.odabranaStipendijaGodina = odabranaStipendijaGodina;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {

            UcitajReport();

            reportViewer1.RefreshReport(); 
        }

        private void UcitajReport()
        {
            var stipendijeStudenata = db.StudentiStipendijeIB180079
                .Include(x=> x.Student)
                .Include(x=> x.StipendijaGodina)
                .Where(x=> x.StipendijaGodinaId == odabranaStipendijaGodina.Id)
                .ToList();

            var tblStipendije = new dsDLWMS.dsStipendijeDataTable();

            for (int i = 0; i < stipendijeStudenata.Count(); i++)
            {
                var Red = tblStipendije.NewdsStipendijeRow();

                Red.Rb = (i + 1).ToString();
                Red.BrojIndeksaImeIPrezime = stipendijeStudenata[i].Student.ToString();
                Red.MjesecniIznos = stipendijeStudenata[i].IznosInfo.ToString();
                Red.UkupniIznos = stipendijeStudenata[i].Ukupno.ToString();

                tblStipendije.Rows.Add(Red);

            }

            var rds = new ReportDataSource();

            rds.Value = tblStipendije;
            rds.Name = "dsStipendije";

            reportViewer1.LocalReport.DataSources.Add(rds);


            var rpc = new ReportParameterCollection();

            var sumaIznos = stipendijeStudenata.Sum(x => x.Ukupno);

            rpc.Add(new ReportParameter("godina", odabranaStipendijaGodina.Godina));

            rpc.Add(new ReportParameter("sumaIznos", sumaIznos.ToString()));

            rpc.Add(new ReportParameter("stipendija", odabranaStipendijaGodina.Stipendija.ToString() ));

            reportViewer1.LocalReport.SetParameters(rpc);

        }
    }
}
