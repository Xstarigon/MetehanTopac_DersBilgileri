using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetehanTopac_DersBilgileri
{
    class FileOperations : IOperations
    {
        string _path = Application.StartupPath.Replace(@"\bin\Debug", "") + @"\Dersler.txt";
        public void AddDers(Ders ders)
        {
            ders.ID = File.ReadAllLines(_path).Length + 1;
            string line = "\n" + ders.ID + ";" + ders.Adi + ";" + (byte)ders.Kategori + ";" + ders.Icerik + ";" + ders.Kredi;
            File.AppendAllText(_path, line);

        }

        public Ders[] GetDersler()
        {
            Ders ders;
            string[] lines = File.ReadAllLines(_path);
            Ders[] dersler = new Ders[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                ders = new Ders()
                {
                    ID = Convert.ToInt32(lines[i].Split(';')[0]),
                    Adi = lines[i].Split(';')[1],
                    Kategori = (KategoriEnum) Convert.ToInt32(lines[i].Split(';')[2]),
                    Icerik = lines[i].Split(';')[3],
                    Kredi = Convert.ToByte(lines[i].Split(';')[4])
                };
                dersler[i] = ders;
            }

            return dersler;
        }
    }
}
