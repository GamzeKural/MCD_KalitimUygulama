using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KalitimUygulama
{
    public class urun:baseClass
    {
        public string marka { get; set; }
        //belirtmiş olduğumuz markalar içerisinde ürün eklenebilsin.
        public string model { get; set; }
        
        
        private decimal _alisFiyat;
        public decimal alisFiyat
        {
            get
            {
                return _alisFiyat;
            }
            set
            {
                if (value<=0)
                {
                    Console.WriteLine("Alış fiyatı 0 dan küçük veya eşit olamaz...");
                }
                else
                {
                    _alisFiyat = value;
                }
            }
        } //0 dan küçük olmamalı.


        private decimal _satisFiyat;
        public decimal satisFiyat
        {
            get
            {
                return _satisFiyat;
            }
            set
            {
                if (value < _alisFiyat)
                {
                    Console.WriteLine("Satış fiyatı alış fiyatından küçük olamaz...");
                }
                else
                {
                    _satisFiyat = value;
                }
            }
        } //Satış fiyatı alış fiyatından küçük olmamalı.


        private decimal _kampanyaFiyat;
        public decimal kampanyaFiyat
        {
            get
            {
                return _kampanyaFiyat;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Kampanya fiyatı 0 dan küçük veya eşit olamaz...");
                }
                else
                {
                    _kampanyaFiyat = value;
                }
            }
        } //0 dan küçük olmamalı.
    }
}
