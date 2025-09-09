using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIB180079
{
    public class CertifikatiGodineIB180079
    {
        public int Id { get; set; }
        public int CertifikatId { get; set; }
        public CertifikatiIB180079 Certifikat { get; set; }
        public int Iznos { get; set; }
        public string Godina { get; set; }
        public bool Aktivan { get; set; }

        public int UkupnoInfo => DateTime.Now.Year.ToString() == Godina ? Iznos * DateTime.Now.Month : Iznos * 12;

        public override string ToString()
        {
            return $"{Certifikat?.Naziv ?? "N/A"}";
        }
    }
}
