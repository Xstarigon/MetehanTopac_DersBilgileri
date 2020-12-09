using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetehanTopac_DersBilgileri
{
    interface IOperations
    {
        Ders[] GetDersler();
        void AddDers(Ders ders);
    }
}
