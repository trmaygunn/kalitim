using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtım_kapsamlı_ödev
{
    public class urun : baseclass
    {

        public string marka { get; set; } // *belirlemiş oldugumuz markalar içerisinde ürün ekleneblilir

        public string model { get; set; }

        private decimal _alisfiyat;
        public decimal alisfiyat
        {
            get { return _alisfiyat; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Alış fiyatı 0 dan küçük veya eşit olamaz");
                }
                else
                {
                    _alisfiyat = value;
                    

                }
            }
        } // 0 dan küçük olamaz
        public decimal satisfiyat
        {
            get { return _satisfiyat; }
            set
            {
                if (value < alisfiyat)
                {
                    Console.WriteLine("ürünün satış fiyatı alış fiyatından küçük olamaz");
                }
                else
                {
                    _satisfiyat = value;
                }
            }
        } // satış fiyatından küçük olamaz
        private decimal _satisfiyat;
        public decimal kampanyafiyat
        {
            get { return _kampanyafiyat; }
            set
            {
                if (value <=0)
                {
                    Console.WriteLine("Kampanya fiyatı 0 dan küçük veya eşit olamaz...");
                }
                         
            }
        } // kampanya fiyat değeri 0 dan küçük olamaz
        private decimal _kampanyafiyat;




    }
}
