﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
  
                #region Alt alta yıldız oluşturma
                //for (int i = 0; i <= 10; i++)
                //{
                //    Console.WriteLine(*);
                //}

                #endregion

                #region Yan Yana yıldız oluşturma
                //for (int i = 0; i <= 10; i++)
                //{
                //    Console.Write(*);
                //}

                #endregion

                #region Alt alta yıldız oluşturma her satırda 10 yıldız.
                //for (int i = 0; i <= 10; i++)
                //{
                //    Console.WriteLine(*********);
                //}

                #endregion

                #region Dik üçgen
                //for (int i = 0; i <= 5; i++)
                //{
                //    for (int j = 0; j <= i; j++) 
                //    {

                //        Console.Write("*");
                //    }
                //    Console.WriteLine();
                //}

                #endregion

                #region Ters üçgen
                //for (int i = 5; i >= 1; i--)
                //{
                //    for (int j = 1; j <= i; j++)
                //    {

                //        Console.Write("*");
                //    }
                //    Console.WriteLine();
                //}

                #endregion

                #region TERS DİK  üçgen beraber
                //for (int i = 1; i <=10 ; i++)
                //{
                //    for (int j = 1; j <= i; j++)
                //    {
                //        Console.Write("*");
                //    }
                //    Console.WriteLine();
                //}
                //for (int i = 10; i >= 1; i--)
                //{
                //    for (int j = 1; j <= i; j++)
                //    {

                //        Console.Write("*");
                //    }
                //    Console.WriteLine();
                //}

                #endregion

                #region Baklava Dilimi
                //int n = 5;


                //for (int i = 1; i <= n; i++)
                //{

                //    for (int j = n; j > i; j--)
                //    {
                //        Console.Write(" "); 
                //    }


                //    for (int k = 1; k <= 2 * i - 1; k++)
                //    {
                //        Console.Write("*");
                //    }

                //    Console.WriteLine(); 
                //}


                //for (int i = n - 1; i >= 1; i--)
                //{
                //    // Print spaces
                //    for (int j = n; j > i; j--)
                //    {
                //        Console.Write(" "); 
                //    }

                //    for (int k = 1; k <= 2 * i - 1; k++)
                //    {
                //        Console.Write("*"); 
                //    }

                //    Console.WriteLine(); 
                //}

                #endregion

                #region Piramit
                //int n = 5;
                //for (int i = 1; i <= n; i++)
                //{
                //    //Boşluklar
                //    for (int j = (n - i); j > 0; j--) 
                //    {
                //        Console.Write(" ");
                //    }

                //    //Yıldızlar
                //    for (int k = 1; k <= ((2 * i) - 1); k++) 
                //    {
                //        Console.Write("*");
                //    }
                //    Console.WriteLine();
                //}

                #endregion

                #region Ters Piramit
                //int n = 5;
                //for (int i = n; i >= 1; i--)
                //{
                //    // Boşluklar
                //    for (int j = 0; j < (n - i); j++)
                //    {
                //        Console.Write(" ");
                //    }

                //    // Yıldızlar
                //    for (int k = 1; k <= ((2 * i) - 1); k++)
                //    {
                //        Console.Write("*");
                //    }
                //    Console.WriteLine();
                //}


                #endregion


                Console.Read();

            }
        }
}
