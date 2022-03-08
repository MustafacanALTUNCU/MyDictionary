// See https://aka.ms/new-console-template for more information
using System;

namespace MyDictionary // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            MyDictionary<int,string> myDictionary = new MyDictionary<int,string>();
            Console.Write("Eklemek istediğiniz Kişi Sayısını Giriniz =");
            int sayi1=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <sayi1 ; i++)
            {
              

                Console.Write("bir sayi giriniz = ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.Write("Bir isim giriniz = ");
                string isim = Console.ReadLine();
                myDictionary.Add(sayi, isim);
            }
            myDictionary.Yazdir();
        }
    }
    
}
