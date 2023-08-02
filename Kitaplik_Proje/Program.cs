using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplik_Proje
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplamfiyat = 0;
            string secim;
            Console.WriteLine("******************************************************************************");
            Console.WriteLine();
            Console.WriteLine("**  Türkçe Kitaplar Kategorisi      **  Yabancı Kitaplar Kategorisi         **");
            Console.WriteLine();
            Console.WriteLine("**  1- Çalıkuşu: Reşat Nuri         **  7- Tuna Kılavuzu: Jules Verne       **");
            Console.WriteLine();
            Console.WriteLine("**  2- Yaban: Yakup Kadri           **  8- Bir Kuzey Macerası: Jack London  **");
            Console.WriteLine();
            Console.WriteLine("**  3- Sinekli Bakkal: Halide Edip  **  9- Altıncı Koğuş: Anton Çehov       **");
            Console.WriteLine();
            Console.WriteLine("**  4- Tehlikeli Oyunlar: Oğuz Atay **  10- Kumarbaz: Dostoyevski           **");
            Console.WriteLine();
            Console.WriteLine("**  5- Geçtiğim Günlerden: H.Yücel  **  11- İki Şehrin Hikayesi: C.Dickens  **");
            Console.WriteLine();
            Console.WriteLine("**  6- Kuyucaklı Yusuf: S.Ali       **  12- Vişne Bahçesi: anton Çehov      **");
            Console.WriteLine();
            Console.WriteLine("******************************************************************************");
            Console.WriteLine();
            Console.WriteLine("***** İşlemler Menüsü *****");
            Console.WriteLine();
            Console.WriteLine("1- Fiyat Sorgulama");
            Console.WriteLine("2- Yeni Okur Kaydı");
            Console.WriteLine("3- Günün Kitabı");
            Console.WriteLine("4- Kitap Arşivi");
            Console.WriteLine("5- Yeni Kitap Satın Al");
            Console.WriteLine("6- Oyun");
            Console.WriteLine();
            Console.Write("Yapmak İstediğiniz İşlemin Numarası: ");
            char islem;
            islem = Convert.ToChar(Console.ReadLine());

            if (islem == '1')
            {
                Console.WriteLine();
                Console.Write("Lütfen Fiyatını Öğrenmek İstediğiniz Kitabın Numarasını Girin: ");
                string numara;
                numara = Console.ReadLine();
                switch (numara)
                {
                    case "1":
                        Console.Write("Çalışıkuşu: 105 TL");
                        break;
                    case "2":
                        Console.Write("Yaban: 90 TL");
                        break;
                    case "3":
                        Console.Write("Sinekli Bakkal: 120 TL");
                        break;
                    case "4":
                        Console.Write("Tehlikeli Oyunlar: 150 TL");
                        break;
                    case "5":
                        Console.Write("Geçtiğim Günlerden: 100 TL");
                        break;
                    case "6":
                        Console.Write("Kuyucaklı Yusuf: 175 TL");
                        break;
                    case "7":
                        Console.Write("Tuna Kılavuzu: 235 TL");
                        break;
                    case "8":
                        Console.Write("Bir Kuzey Macerası: 200 TL");
                        break;
                    case "9":
                        Console.Write("Altıncı Koğuş: 175 TL");
                        break;
                    case "10":
                        Console.Write("Kumarbaz: 225 TL");
                        break;
                    case "11":
                        Console.Write("İki Şehrin Hikayesi: 190 TL");
                        break;
                    case "12":
                        Console.Write("Vişne Bahçesi: 250 TL");
                        break;
                    default:Console.Write("YANLIŞ NUMARA GİRDİNİZ!");break;

                }
            }
            if (islem == '2')
            {
                Console.WriteLine();
                Console.WriteLine("***** Yeni Okur Kaydı *****");
                string ad, soyad, universite;
                Console.Write("Adınız: ");
                ad = Console.ReadLine();
                Console.Write("Soyadınız: ");
                soyad = Console.ReadLine();
                Console.Write("Üniversiteniz: ");
                universite = Console.ReadLine();

                string dosya = @"C:\Users\soyle\OneDrive\Masaüstü\kullanici.txt";
                StreamWriter sw = new StreamWriter(dosya);
                sw.WriteLine("Adınız: " + ad);
                sw.WriteLine("Soyadınız: " + soyad);
                sw.WriteLine("Üniversiteniz: " + universite);
                sw.Close();
            }
            if (islem == '3')
            {
                Console.WriteLine();
                Console.WriteLine("***************************************************");
                Console.WriteLine();
                Console.WriteLine("*****    Bugünün Kitabı: Kuyucaklı Yusuf      *****");
                Console.WriteLine();
                Console.WriteLine("***************************************************");
                
            }
            if (islem == '4')
            {
                Console.WriteLine();
                Console.WriteLine("***************************************************");
                Console.WriteLine();
                FileStream fs = new FileStream(@"C:\Users\soyle\OneDrive\Masaüstü\kitaplar.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string metin = sr.ReadLine();
                while (metin != null)
                {
                    Console.WriteLine(metin);
                    metin = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
                // aaaa
                Console.WriteLine();
                Console.WriteLine("***************************************************");
            }
            if (islem == '5')
            {
                for(int i = 1; i < 100; i++)
                {
                    Console.WriteLine();
                    Console.Write("Alacağınız Kitap Numarası: ");
                    secim = Console.ReadLine();
                    if(secim == "1")
                    {
                        toplamfiyat += 105;
                    }
                    else if(secim == "2")
                    {
                        toplamfiyat += 90;
                    }
                    else if (secim == "3")
                    {
                        toplamfiyat += 120;
                    }
                    else if (secim == "4")
                    {
                        toplamfiyat += 150;
                    }
                    else if (secim == "5")
                    {
                        toplamfiyat += 100;
                    }
                    else if (secim == "6")
                    {
                        toplamfiyat += 175;
                    }
                    else if (secim == "7")
                    {
                        toplamfiyat += 235;
                    }
                    else if (secim == "8")
                    {
                        toplamfiyat += 200;
                    }
                    else if (secim == "9")
                    {
                        toplamfiyat += 175;
                    }
                    else if (secim == "10")
                    {
                        toplamfiyat += 225;
                    }
                    else if (secim == "11")
                    {
                        toplamfiyat += 190;
                    }
                    else if (secim == "12")
                    {
                        toplamfiyat += 250;
                    }
                    else
                    
                        Console.WriteLine("Yanlış Kitap Numarası Girdiniz!");
                        Console.WriteLine();
                        Console.Write("Başka Bir Kitap Almak İster misiniz? ");
                        string cevap = Console.ReadLine();
                        if (cevap == "h" || cevap == "H" || cevap == "hayır" || cevap == "Hayır")
                            break; 
                    
                }
                Console.WriteLine("Toplam Tutar: " + toplamfiyat);
            }
            if (islem == '6')
            {
                Console.WriteLine();
                int tahmin = 0;
                Random rnd = new Random();
                int sayi = rnd.Next(1, 100);
                while(sayi != tahmin)
                {
                    Console.Write("Sayı Giriniz: ");
                    tahmin = Convert.ToInt16(Console.ReadLine());
                    if(tahmin > sayi)
                    {
                        Console.WriteLine("Daha Küçük!");
                    }
                    if(tahmin < sayi)
                    {
                        Console.WriteLine("Daha Büyük!");
                    }
                    if(tahmin == sayi)
                    {
                        Console.Write("Bildiniz!!!");
                        break;
                    }
                }
            }


            Console.Read();
        }
    }
}
