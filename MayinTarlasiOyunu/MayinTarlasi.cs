using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayinTarlasiOyunu
{
    internal class MayinTarlasi
    {
        Size Buyukluk;

        List<Mayin> mayinlar;
        int doluMayinSayisi;
        Random rnd = new Random();
        public MayinTarlasi(Size buyukluk, int mayinSayisi)
        {
            mayinlar = new List<Mayin>();
            doluMayinSayisi = mayinSayisi;
            Buyukluk = buyukluk;

            for (int x = 0; x < buyukluk.Width; x=x+20)
            {
                for (int y = 0; y < buyukluk.Height; y=y+20)
                {
                    Mayin m = new Mayin(new Point(x, y));
                    MayinEkle(m);
                }
            }
            MayinlariDoldur();

        }
        public Size Buyuklugu 
        {
            get { return Buyukluk; }
        }

        private void MayinlariDoldur()
        {
            int sayi = 0;
            while (sayi < doluMayinSayisi)
            {
                int i = rnd.Next(0,mayinlar.Count);
                Mayin item = mayinlar[i];
                if (item.mayinVarmi==false)
                {
                    item.mayinVarmi = true;
                    sayi++;
                }
            }
        }
        public void MayinEkle(Mayin m)
        {
            mayinlar.Add(m);
        }
        public Mayin MayinAlLocation(Point loc)
        {
            foreach (Mayin item in mayinlar)
            {
                if (item.konumAl == loc)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Mayin> GetAllMayin { get { return mayinlar; } }
    }
}
