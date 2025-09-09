using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIB180079
{
    public class StudentiCertifikatiIB180079
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int CertifikatGodinaId { get; set; }
        public CertifikatiGodineIB180079 CertifikatGodina { get; set; }

        public string GodinaInfo => CertifikatGodina?.Godina ?? "N/A";

        public string CertifikatInfo => CertifikatGodina?.Certifikat?.Naziv ?? "N/A";

        public int IznosInfo => CertifikatGodina?.Iznos ?? 0;

        public int UkupnoInfo => DateTime.Now.Year.ToString() == CertifikatGodina.Godina ? CertifikatGodina.Iznos * DateTime.Now.Month : CertifikatGodina.Iznos * 12;

    }
}
