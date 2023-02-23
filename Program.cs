using System;

namespace odev
{
    public static class Program
    {
     static void Main(string[] args)
        {
        Console.WriteLine("Lütfen bir pozitif sayı giriniz");
        int sayi = int.Parse(Console.ReadLine());

        Console.WriteLine($"Lütfen {sayi} tane sayı giriniz");

        int[] sayilar = new int[sayi];
        List<int> cift_sayilar = new List<int>();

        for(int i=0; i<sayi; i++)
        {
            sayilar[i] = int.Parse(Console.ReadLine());
            if(sayilar[i]%2==0)
            {
                cift_sayilar.Add(sayilar[i]);
            }
        }
        Console.WriteLine("Girdiğiniz Sayılardan Çift Olanlar");
        foreach (int ciftler in cift_sayilar)
        {
            Console.Write(ciftler+" ");
        }
        Console.WriteLine("");
        /////////////////////
        Console.WriteLine("Birinci pozitif sayıyı giriniz");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("İkinci pozitif sayıyı giriniz");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine($"Lütfen {n} adet pozitif sayı giriniz");
    
       
        List<int> girilenSayi = new List<int>();
        int[] sayilar_2 = new int[n];
        
        for(int i=0;i<n;i++)
        {
            sayilar_2[i] =int.Parse(Console.ReadLine());

            if(sayilar_2[i]==m || sayilar_2[i]%m==0)
            girilenSayi.Add(sayilar_2[i]);
        }
        Console.WriteLine("Girilen sayılardan ikincis sayıya eşit olan veya tam bölünenler");
        foreach (int sayilarimiz in girilenSayi)
        {
            Console.Write(sayilarimiz+" ");
        }

            Console.WriteLine(" ");
        // /////////////

        Console.WriteLine("Bir pozitif sayı giriniz");
        int kelimeSayisi= int.Parse(Console.ReadLine());
        Console.WriteLine($"{kelimeSayisi} sayısı kadar kelime giriniz");

        string[] kelimeDizisi = new string[kelimeSayisi];

        for( int i =0; i<kelimeSayisi; i++)
        {
            kelimeDizisi[i]=Console.ReadLine();
        }

        Array.Reverse(kelimeDizisi);
        foreach(var item in kelimeDizisi)
            Console.WriteLine(item);
        
        Console.WriteLine("");


////////////////////////////
        Console.WriteLine("Bir Cümle Giriniz");
        string cumle = Console.ReadLine();

        string [] kelime_sayisi = cumle.Split(" ");
        Console.WriteLine("Kelime Sayısı = "+kelime_sayisi.Length);
        
        int karakter_sayisi = 0;
        for(int i = 0; i < kelime_sayisi.Length;i++)
        {
            karakter_sayisi += kelime_sayisi[i].Length;
        }
        Console.WriteLine("Karakter Sayısı= " +karakter_sayisi);
        }
    }
}
