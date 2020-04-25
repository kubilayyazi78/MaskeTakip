using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Degiskenler();
            Vatandas vatandas = new Vatandas();
            
            

            Console.ReadLine();
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
