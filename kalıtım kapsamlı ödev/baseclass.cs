using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtım_kapsamlı_ödev
{
    public class baseclass
    {
        public static int sayac=1; //ilk oluştuğu zaman 1 değerini default olarak alsın
        public baseclass()
        {
            _id = sayac;
            sayac = sayac + 1;
        }
        private int _id;
        public int id
        {
            get
            {
                return _id;
            }
            private set 
            {
             


            }
        }


        private string _barkod;
        public string barkod
        {
            get { return _barkod; }
            set
            {
                bool kontrolislemi = sanaldatabase.dbbarkodkontrol(value);
                if(!kontrolislemi) //değeri sanal database üzerinden bulamadım
                {
                    _barkod = value;
                }
                else
                {
                    Console.WriteLine("sanal database içerisinde bu barkod değeri daha önce girilmiştir...");
                }
            }
        }
        public DateTime olusturmatarihi { get; set; }
        public int olusturankullanici { get; set; }
        public DateTime guncellemetarihi { get; set; }
        public int güncelleyenkullanici { get; set; }
        public bool silindi { get; set; }



    }
}
