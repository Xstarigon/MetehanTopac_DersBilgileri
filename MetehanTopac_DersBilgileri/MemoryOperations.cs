using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetehanTopac_DersBilgileri
{
    class MemoryOperations : IOperations
    {
        private List<Ders> dersler = new List<Ders>()
        {
            new Ders()
                { ID = 1, Adi = "Matematik", Icerik = "Mantık", Kategori = KategoriEnum.Sayısal, Kredi = 4 },
            new Ders()
                { ID = 2, Adi = "Tarih", Icerik = "Atatürk Dönemi", Kategori = KategoriEnum.Sözel, Kredi = 3 }

        };
        public void AddDers(Ders ders)
        {
            ders.ID = dersler.Count + 1;
            dersler.Add(ders);
        }

        
        public Ders[] GetDersler()
        {
            Ders[] ders = new Ders[dersler.Count];
            for (int i = 0; i < dersler.Count; i++)
            {
                ders[i] = dersler[i];
            }

            return ders;
        }
    }
}
