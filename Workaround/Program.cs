using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Degiskenler();
            Vatandas vatandas = new Vatandas();

            SelamVer("Kubilay");
            SelamVer("Miray");
            SelamVer();
            int sonuc = Topla();

            string ogrenc1 = "kubi";
            string ogrenci2 = "miray";
            string ogrenci3 = "ali";

            Console.WriteLine(ogrenc1);

            string[] ogrenciler = new string[3];

            ogrenciler[0] = "kubi"; 
            ogrenciler[1] = "ali";
            ogrenciler[2] = "melek";
            ogrenciler = new string[4];
            ogrenciler[3] = "yeni";
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler = new[] { "ank", "izmir", "karabük" };
            string[] sehirler2 = new[] { "a", "b", "c" };

            sehirler2 = sehirler;

            sehirler[0] = "adana";

            Console.WriteLine(sehirler2[0]);

            int sayi1 = 10;
            int sayi2 = 20;

            sayi2 = sayi1;

            sayi1 = 30;

            foreach (string item in sehirler)
            {
                Console.WriteLine(item);
            }

            List<string> yeniSehirler = new List<string>
            {
                "K",
                "L",
                "C"

            };

            yeniSehirler.Add("karabük");

            foreach (var item in yeniSehirler)
            {
                Console.WriteLine(item);
            }
            Person person = new Person();
            person.FirstName = "KUBİLAY";
            person.LastName = "YAZI";
            person.DateOfBirthYear = 1996;
            person.NationalIdentity=45545;
            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person);
          //  pttManager.GiveMask(person);

            Console.ReadLine();
        }

        static void SelamVer(string isim="İsimsiz")
        {
            Console.WriteLine(isim+" selam");
        }

        static int Topla(int sayi1=5 , int sayi2=10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : "+sonuc);
            return sonuc;
        }

        private static void Degiskenler()
        {
            string mesaj = "Selam";
            double tutar = 1000;

            int a = 100;

            string ad = "Kubilay";
            string soyad = "Yazi";
            int dogumYili = 1996;
            long tcNo = 57342658896;


            bool girisYapmisMi = true;
            Console.WriteLine(tutar * 1.18);
            Console.WriteLine(mesaj);
        }
    }
    //PASCAL CASING
    public class Vatandas
    {

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }

        //public string ad = "Kubilay";
        //public string soyad = "Yazi";
        //public int dogumYili = 1996;
        //public long tcNo = 57342658896;

        //public olduğu için ilk harf büyük olabilir.
    }


}
