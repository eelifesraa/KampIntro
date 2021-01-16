using System;

namespace DegerVeReferansTipler
{
    //int,double,float,bool => deger tip
    //array,class,interface => referans tip adres tutarlar 

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar[0] 999; sayılar2 nin adresi tutulduğu için değiştiğinde o da değişir
            // pointir
            // c# garbıc collector sayi1 in içindekini 10,20,30 olanı toplar siler 



        }
    }
}
