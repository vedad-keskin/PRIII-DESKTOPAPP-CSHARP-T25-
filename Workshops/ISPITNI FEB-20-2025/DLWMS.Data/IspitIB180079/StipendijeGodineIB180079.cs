using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIB180079
{
    public class StipendijeGodineIB180079
    {
        public int Id { get; set; }
        public int StipendijaId { get; set; }
        public StipendijeIB180079 Stipendija  { get; set; }
        public string Godina { get; set; }
        public int Iznos { get; set; }
        public bool Aktivan { get; set; }

        public override string ToString()
        {
            return $"{Stipendija.Naziv}";
        }
    }
}
