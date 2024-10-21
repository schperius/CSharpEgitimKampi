using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri

            //DeğişkenTürü [] DiziAdı = new DeğişkenTürü [ElemanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Mavi";
            //colors[2] = "Sarı";
            //colors[3] = "Beyaz";

            //Console.WriteLine(colors[2]);



            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "iStanbul";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[2]);



            //int[] numbers = new int[10];

            //numbers[0] = 1;
            //numbers[1] = 56;
            //numbers[2] = 78954;
            //numbers[6] = 789;
            //numbers[4] = 456;
            //numbers[8] = 158;

            //Console.WriteLine(numbers[5]);

            //Bir indekse eğer ki değer atamazsan default olarak "0" değerini gösterir.





            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };

            //Console.WriteLine(cities[2]);
            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}




            //int[] numbers = { 1, 85, 99, 87, 52, 78, 51, 30, 33, 2345, 7854, 1120 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}




            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}




            //int[] myArray = { 47, 85, 456, 564, 98, 21, 32, 789, 542, 123, 65 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);




            //---------------------------------------------------------//---------------------------------------------------------//---------------------------------------------------------//---------------------------------------------------------
            ////length= dizinin uzunluğunu verir örneğin;

            //string[] person = { "ahmet", "ayşe", "veli", "fatma", "buse", "deniz" };
            //Console.WriteLine(person.Length);




            //---------------------------------------------------------//---------------------------------------------------------//---------------------------------------------------------//---------------------------------------------------------
            //sort = sıralama işlemini yapar.

            //int[] numbers = { 1, 45, 85, 65, 74, 10, 22, 35 };
            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            //reverse = sondan başlayarak başa doğru sıralama işlemi yapar.

            //int[] numbers = { 1, 45, 85, 65, 74, 10, 22, 35 };
            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            #endregion

            #region Dizi Metotları

            //string[] customers = { "ali", "buse", "çınar", "kaya", "merve", "ayşegül]" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);




            //int[] numbers = { 46, 85, 96, 63, 7, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() + " Dizinin en küçük elemanı: " + numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. şehri giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("--------------------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}





            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);



            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            //Console.WriteLine("Çift Sayılar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            //Console.WriteLine();
            //Console.WriteLine("---------------------------");
            //Console.WriteLine();


            //Console.WriteLine("Tek Sayılar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            

            #endregion

            Console.Read();
        }
    }
}
