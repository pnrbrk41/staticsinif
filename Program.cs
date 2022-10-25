using System;

namespace staticsinif
{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Calişan sayisi: {0}",Calisan.CalisanSayisi);

            Calisan calisan= new Calisan("ayse","dur","ik");
            Console.WriteLine("Calisan sayisi: {0}", Calisan.CalisanSayisi);

            Calisan calisan1=new Calisan("pınar","ak","muhendis");
            Calisan calisan2=new Calisan("burak","ak","formen");
            Console.WriteLine("Calisan sayisi: {0}", Calisan.CalisanSayisi);
            Console.WriteLine("Toplama islemi sonucu: {0}", İslemler.Topla(100,200));
            Console.WriteLine("Cikarma işlemi sonucu: {0}", İslemler.Cikar(300,100));
        }
    }
    class Calisan{
        private static int calisanSayisi;

        public static int CalisanSayisi{ get=> calisanSayisi; set=> calisanSayisi=value;}
        private string Isim;
        private string Soyisim;
        private string Departman;


        public Calisan(string isim, string soyisim, string departman){
            this.Isim=isim;
            this.Soyisim=soyisim;
            this.Departman=departman;
            Console.WriteLine("Calisan Bilgileri:{0}", isim);
            CalisanSayisi++;
        }
    } 
    static class İslemler{
        public static long Topla(int sayi1, int sayi2){
            return sayi1+sayi2;
        }
        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1-sayi2;
        }
    }
}