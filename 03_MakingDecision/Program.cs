using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If Else

            //Console.Write("Lutfen Şifrenizi Giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}

            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}




            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("Bilgiler Doğru");
            //}
            //else
            //{
            //    Console.Write("Bilgiler Yanlış");
            //}




            //int number;
            //Console.Write("Sayıyı Giriniz: ");
            //number= int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış");
            //}





            //int exam1, exam2, exam3, average;
            //string result = "Hata!";

            //Console.Write("Sınav 1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{

            //    result = "Sonuç vasat";
            //}

            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç orta";
            //}

            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç iyi";
            //}

            //if (average > 84)
            //{
            //    result = "Sonuç çok iyi";
            //}

            //Console.WriteLine(result);



            //string city;
            //Console.Write("Lutfen şehri giriş yapınıız: ");
            //city = Console.ReadLine();

            //if(city=="ankara" | city=="bursa" | city=="konya" | city=="trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}



            //string username;              //her iki şekilde de kullanılıyor hem satır 123 hemde bu satırdaki şekilde.
            //Console.Write("Lutfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz");
            //}


            #endregion

            #region Mod İşlemleri

            //int number = 27;
            //int result = number % 5;
            //Console.WriteLine(result);



            //Console.Write("Lütfen 1.sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1.sayınının 2.sayıya bölümünden kalan: " + result);

            //Console.Write(result);  //ikinci kullanım sekli.




            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Bu sayı çifttir ");
            //}
            //else
            //{
            //    Console.Write("Bu sayı tektir ");
            //}

            #endregion

            #region Char Değişkenler İle Karar Yapıları
            //char team;
            //Console.Write("Lütfen takımınızın sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe ");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş ");
            //}

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatarasay ");
            //}
            #endregion


            #region Örnek Proje Uygulaması

            //Console.WriteLine("****** C# Eğitim Kampı Yemek Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Salatalar");
            //Console.WriteLine("4- Tatlılar");
            //Console.WriteLine("5- İçecekler");
            //Console.WriteLine("-----------------------------");


            //string menuItem;
            //Console.WriteLine("Detayını görmek istediğiniz yemek menüsünü seçiniz: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Ana Yemekler ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Köri Soslu Tavuk");
            //    Console.WriteLine("2- Kızartma Tabağı");
            //    Console.WriteLine("3- Fasülye Pilav");
            //    Console.WriteLine("4- Fırında Somon");
            //    Console.WriteLine("5- Patlıcan Musakka");
            //    Console.WriteLine("---------- Ana Yemekler ----------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Çorbalar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek");
            //    Console.WriteLine("2- Ezogelin");
            //    Console.WriteLine("3- Yoğurt");
            //    Console.WriteLine("4- Kelle Paça");
            //    Console.WriteLine("5- Tel Şehriye");
            //    Console.WriteLine("---------- Çorbalar ----------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Salatalar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Akdeniz");
            //    Console.WriteLine("2- Çoban");
            //    Console.WriteLine("3- Tonbalıklı");
            //    Console.WriteLine("---------- Salatalar ----------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Tatlılar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Supangle");
            //    Console.WriteLine("2- Sütlaç");
            //    Console.WriteLine("3- Tel Kadayıf");
            //    Console.WriteLine("4- Künefe");
            //    Console.WriteLine("5- Baklava");
            //    Console.WriteLine("---------- Tatlılar ----------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- İçecekler ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kola");
            //    Console.WriteLine("2- Fanta");
            //    Console.WriteLine("3- Çay");
            //    Console.WriteLine("4- Türk Kahvesi");
            //    Console.WriteLine("5- İceTea");
            //    Console.WriteLine("6- Soda");
            //    Console.WriteLine("7- Gazoz");
            //    Console.WriteLine("---------- İçecekler ----------");

            //    Console.WriteLine();
            //}
            #endregion


            #region Switch Case

            //Console.Write("Lütfen ay girişini yapınız: ");
            //int monthNumber=int.Parse(Console.ReadLine());

            //switch(monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;

            //    default:Console.Write("Hatalı Veri Girişi "); break;
            //}



            #endregion


            #region Switch Case Hesap Makinesi


            int number1, number2, result;
            char symbol;

            Console.Write("1. sayıyı giriniz: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("2. sayıyı giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen yapmak istediğiniz işlemin sembolünü yazınız: ");
            symbol = char.Parse(Console.ReadLine());

            switch(symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.Write("Toplam: " + result);
                    break;

                case '-':
                    result = number1 - number2;
                    Console.Write("Fark: " + result);

                    break;
                
                case '*':
                    result = number1 * number2;
                    Console.Write("Çarpım: " + result);
                    break;

                case '/':
                    result = number1 / number2;
                    Console.Write("Bölme: " + result);
                    break;

            }
            
            #endregion
            Console.Read();

        }
    }
}