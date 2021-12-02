using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KalitimUygulama
{
    public class baseClass
    {
        public static int sayac = 1;
        //İlk oluştuğu zaman 1 değerini otomatik olarak alsın.

        private int _id;
        public int id
        {
            get
            {
                return _id;
            }
            private set
            {
                //bir sayaç içerisindekideğerden faydalanmak istiyoruz.
                //_id=sayac;
                //sayac=sayac+1;
                //nedeni basit set alanı private olarak işaretlendi.
            }
        }

        public baseClass()
        {
            _id = sayac;
            sayac++;
        }

        private string _barkod;
        public string barkod 
        {
            get
            {
                return _barkod;
            }
            set
            {
                bool kontrolIslemi = sanalDataBase.dbBarkodKontrol(value);
                if (!kontrolIslemi) //değeri sanal database içinde bulamadık.
                {
                    _barkod = value;
                }
                else
                {
                    Console.WriteLine("Sanal database içerisinde bu barkod değeri daha önce girilmiştir.");
                }
            }
        } 

        public DateTime olusturmaTarih { get; set; }
        public int olusturulanKullanici { get; set; }
        public DateTime guncellemeTarih { get; set; }
        public int guncelleyenKullanici { get; set; }
        public bool silindi { get; set; }

    }
}
