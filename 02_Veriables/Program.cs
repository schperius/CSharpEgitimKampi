using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler

            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, patatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //patatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice +" TL");
            //Console.WriteLine("---- Portakal Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + patatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " TL");

            //Console.WriteLine("----------------------------------------------------");

            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, patatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //patatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice= applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double patatoTotalPrice = patatoPrice * patatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyatı " + applePrice + " - Gramajı " +appleGram + " - Toplam " +
            //    "Fiyat " + appleTotalPrice + " TL");

            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyatı " + orangePrice + " - Gramajı " + orangeGram + " - Toplam " +
            //    "Fiyat " + orangeTotalPrice + " TL");

            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyatı " + strawberryPrice + " - Gramajı " + strawberryGram + " - Toplam " +
            //    "Fiyat " + strawberryTotalPrice + " TL");

            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyatı " + patatoPrice + " - Gramajı " + patatoGram + " - Toplam " +
            //     "Fiyat " + patatoTotalPrice + " TL");

            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyatı " + tomatoPrice + " - Gramajı " + tomatoGram + " - Toplam " +
            //     "Fiyat " + tomatoTotalPrice + " TL");


            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------------------");
            //Console.WriteLine();


            //double shoppingTotalPrice = appleTotalPrice+ orangeTotalPrice+ tomatoTotalPrice + patatoTotalPrice+ tomatoTotalPrice;

            //Console.WriteLine("Alışveriş Tutarınız Toplam: " + shoppingTotalPrice + " TL");



            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcunun Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcunun Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcunun İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Yolcunun Şehir Bİlgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcunun Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcunun TC Kimlik Numarası: ");
            //passengerIdentityNumber = Console.ReadLine();


            //Console.WriteLine();

            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + " - Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " + passengerDistrict + "/" + passengerCity
            //    + " " + passengerAge);




            #endregion

            #region Klaveyeden Tam Sayı Girişleri Ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12500;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Televizyon Sayısını Giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());


            //int totalPrice= shoesCount*shoesPrice + computerCount*computerPrice + chairCount*chairPrice
            //    + tvCount*tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice +" TL");




            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. Sınav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);


            #endregion

            Console.Read();
        }
    }
}
