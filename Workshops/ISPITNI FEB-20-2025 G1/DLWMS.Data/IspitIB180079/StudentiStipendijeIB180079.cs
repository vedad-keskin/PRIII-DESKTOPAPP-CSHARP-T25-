using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIB180079
{
    public class StudentiStipendijeIB180079
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int StipendijaGodinaId { get; set; }
        public StipendijeGodineIB180079 StipendijaGodina { get; set; }

        public string GodinaInfo => StipendijaGodina?.Godina ?? "N/A";
        public string StipendijaInfo => StipendijaGodina?.Stipendija?.Naziv ?? "N/A";
        public int IznosInfo => StipendijaGodina?.Iznos ?? 0;

        // Laksi al nepotpun način

        //public int Ukupno => StipendijaGodina?.Iznos * 12 ?? 0;

        public int Ukupno => StipendijaGodina?.Ukupno ?? 0;


    }
}
