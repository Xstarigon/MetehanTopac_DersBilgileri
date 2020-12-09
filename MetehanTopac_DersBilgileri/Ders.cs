using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetehanTopac_DersBilgileri
{
    class Ders
    {
        public int ID { get; set; }
        public string Adi { get; set; }
        public KategoriEnum Kategori { get; set; }
        public string Icerik { get; set; }
        public byte Kredi { get; set; }
    }
}
