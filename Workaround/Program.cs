using System;
using Business.Concrete;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        //string mesaj = "Merhaba";
        //double tutar = 10000.2;
        //int sayi = 124;
        //bool girisYapmisMi = true;

        //string ad = "Berker";
        //string soyad = "ERTAN";
        //int dogumYili = 1998;
        //long tcNo = 1234567890;
        //Console.WriteLine("Merhaba!");



        SelamVer("Berker");
        int sonuc = Topla(3,5);

        //Diziler = Arrays

        string ogrenci1 = "Berker";
        string ogrenci2 = "Kerem";
        string ogrenci3 = "Veli";

        string[] ogrenciler = new string[3];
        ogrenciler[0] = "Berker";
        ogrenciler[1] = "kerem";
        ogrenciler[2] = "veli";

        ogrenciler = new string[4];
        ogrenciler[3] = "Ali";



        for (int i = 0; i < ogrenciler.Length; i++)
        {
            Console.WriteLine(ogrenciler[i]);
        }

        string[] sehirler1 = new[] { "Ankara", "İstanbul","İzmir"};
        string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

        sehirler2 = sehirler1;
        sehirler1[0] = "Adana";
        Console.WriteLine(sehirler1[0]);
        //adana

        int sayi1 = 10;
        int sayi2 = 20;
        sayi2 = sayi1;
        sayi1 = 30;
        //10

        foreach (string sehir in sehirler1)
        {
            Console.WriteLine(sehir);
        }

        List<string> yeniSehirler = new(){ "Ankara 1", "İstanbul 1", "İzmir1" };
        yeniSehirler.Add("Adana1");
        foreach (var sehir in yeniSehirler)
        {
            Console.WriteLine(sehir);
        }

        Person person1 = new();
        person1.FirstName = "Berker";
        person1.LastName = "Ertan";
        person1.DateOfBirthYear = 1998;
        person1.NationalIdentity = 471;



        PttManager pttManager = new(new PersonManager());
        pttManager.GiveMask(person1);






        Console.ReadLine();
    }

    static void SelamVer(string isim="isimsiz")
    {
        Console.WriteLine("Merhaba " + isim);
    }

    static int Topla(int sayi1,int sayi2)
    {
        int sonuc = sayi1 + sayi2;
        Console.WriteLine("Toplam" + sonuc.ToString());
        return sayi1 + sayi2;
    }
}


public class Vatandas
{
    public string Ad { get; set; }
    public string SoyAd { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }
}