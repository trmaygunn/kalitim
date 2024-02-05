using kalıtım_kapsamlı_ödev;

class program
{


    static void Main(string[] args)
    {
        bilgisayar b1 = new bilgisayar();
        //b1.id = 1;
        b1.marka = "monster";
        b1.model = "abra a5";
        b1.islemci = "i5";
        b1.alisfiyat = 1000;
        b1.satisfiyat = 1500;
        b1.kampanyafiyat = 1000;
        b1.barkod = "123456789";
        sanaldatabase.yeniurunekle(b1 );


        bilgisayar b2 = new bilgisayar();
        //b1.id = 1;
        b2.marka = "monster";
        b2.model = "abra a5";
        b2.islemci = "i5";
        b2.alisfiyat = 1000;
        b2.satisfiyat = 1500;
        b2.kampanyafiyat = 1000;
        b2.barkod = "123456789";
        sanaldatabase.yeniurunekle(b2);
        



        
        


    }



}
