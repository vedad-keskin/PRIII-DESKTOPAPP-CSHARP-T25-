using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIB180079
{
    public class RazmjeneIB180079
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student? Student { get; set; }

        public int UniverzitetId { get; set; }
        public UniverzitetiIB180079? Univerzitet { get; set; }
        public DateTime DatumPocetak { get; set; }
        public DateTime DatumKraj { get; set; }
        public int ECTS { get; set; }
        public bool Okoncana { get; set; }
    }
}
