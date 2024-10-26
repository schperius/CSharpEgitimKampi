using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Metotlar

            //()
            //Metotlar mor kutucuk
            //Geriye değer döndürmeyen metotlar
            //customer-->> listele, ekle, sil, güncelle


            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();




            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();







            #endregion


            #region Geriye Değer Döndürmeyen String Paramatere Metotlar

            //void WriteMethod(string CustomerName)
            //{
            //    Console.WriteLine(CustomerName);
            //}
            //WriteMethod("Muhammet Karakoç");



            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: "+ name + " " + surName);
            //}

            //CustomerCard("Muhammet", "Karakoç");
            //CustomerCard("İpek", "Altıntaş");



            #endregion

            #region Geriye Değer Döndürmeyen Int Paramatere Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(4, 5, 6);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Muhamemt Karakoç";
            //}

            //CustomerName();




            //string studentCard() 
            //{
            //    string name = "Muhammet";
            //    string surName = "Karakoç";

            //    return name+ " "+ surName;
            //}

            //Console.WriteLine(studentCard());
            #endregion

            #region Geriye Değer Döndüren String Parametre Metotlar

            //string CountryCard(string countryName , string capital , string flagColor) 
            //{
            // string cardInfo = "Ülke: " + countryName + " - Başkenti: " + capital + " - Bayrak Rengi: " + flagColor;
            // return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengini giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y, z));

            //Console.WriteLine(CountryCard("Türkiye" , "Ankara", "Kırmızı-Beyaz"));

            #endregion

            #region Geriye Değer Döndüren Int Parametre Metotlar

            //int Sum(int number1 ,  int number2)
            //{
            //    int result = number1 + number2;
            //    return result;

            //}

            //Console.WriteLine(Sum(35, 9));
            //Console.WriteLine(Sum(31, 18));
            //Console.WriteLine(Sum(95, 90));
            //Console.WriteLine(Sum(78, 74));
            //Console.WriteLine(Sum(65, 20));

            #endregion

            #region Örnek Uygulama

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + "isimli öğrenci sınavı başarıyla geçti " + " - Ortalaması: " + result;
                }
                else 
                {
                    return student + "isimli öğrenci sınavı geçemedi " + " - Ortalaması: " + result;

                }
            }

            Console.WriteLine(ExamResult("Muhammet ", 85, 90, 80));
            Console.WriteLine(ExamResult("İpek ", 50, 40, 20));
            #endregion

            Console.Read();
        }
    }
}
