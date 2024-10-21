using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region alt alta 10 tane yıldız oluşturma

            //for (int i = 0; i<=10; i++)
            //{
            //    Console.WriteLine("*");
            //}
            #endregion


            #region yan yana 10 tane yıldız oluşturma

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}
            #endregion

            #region alt alta 10 tane yıldız oluşturma her satırta 10 yıldız olsun

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("");
            //}
            #endregion

            #region Yıldızlarla üçgen

            //for (int i = 1; i <=5; i++)
            //{
            //    for (int j = 1;  j <=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Yıldızlarla ters üçgen

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion


            #region dik ve ters üçgen Oluşturma

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int h = 4; 1 <= h; h--)
            //{
            //    for (int k = 1; k <= h; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion


            #region baklava dilimi


            //int n = 5;

            //for(int i = 1 ; i <= n; i++)
            //{
            //    for(int j = n-1 ; j > 0 ; j--)
            //    {
            //        Console.Write(" ");
            //    }


            //for (int k = 1; k <= 2 * i - 1; k++)
            //{
            //    Console.Write("*");
            //}

            //Console.WriteLine();

            //}

            //// alt kısım

            //for (int i = n-1 ; i >= 1; i--)
            //{
            //    for (int j =n -1 ; j > 0 ; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k= 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion



            #region piramit oluşturma


            //int n = 5;

            //for (int i=1; i <= n; i++)
            //{
            //    //boşluk
            //    for (int j = n -i ; j>0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    //yıldız
            //    for(int k=1; k <=2 *i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion


            #region ters piramit

            int n = 5;
            for (int i = n; i >= 1; i--)
            {
                //boşluklar
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                //yıldızlar
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            #endregion


            Console.Read();
        }
    }
}