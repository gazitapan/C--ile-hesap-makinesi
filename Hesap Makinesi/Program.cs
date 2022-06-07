using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesap_Makinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Toplama için 1 giriniz.");
            Console.WriteLine("Çıkarma için 2 giriniz.");
            Console.WriteLine("Çarpma için 3 giriniz.");
            Console.WriteLine("Bölme için 4 giriniz.");
            byte işlemNo;
            Console.WriteLine("İşlem Seçiniz: ");
            işlemNo = Convert.ToByte(Console.ReadLine());
            double sayi1, sayi2, işlemSonucu;
            if (işlemNo == 1)
            {
                Console.WriteLine("Bir sayı giriniz: ");
                sayi1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Bir sayı giriniz: ");
                sayi2 = Double.Parse(Console.ReadLine());
                işlemSonucu = sayi1 + sayi2;
                Console.WriteLine("{0}+{1}= {2}", sayi1, sayi2, işlemSonucu);


            }
            else if (işlemNo == 2)
            {
                Console.WriteLine("Bir sayı giriniz: ");
                sayi1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Bir sayı giriniz: ");
                sayi2 = Double.Parse(Console.ReadLine());
                işlemSonucu = sayi1 - sayi2;
                Console.WriteLine("{0}-{1}= {2}", sayi1, sayi2, işlemSonucu);


            }
            else if (işlemNo == 3)
            {
                Console.WriteLine("Bir sayı giriniz: ");
                sayi1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Bir sayı giriniz: ");
                sayi2 = Double.Parse(Console.ReadLine());
                işlemSonucu = sayi1 * sayi2;
                Console.WriteLine("{0}*{1}= {2}", sayi1, sayi2, işlemSonucu);


            }
            else if (işlemNo == 4)
            {
                Console.WriteLine("Bir sayı giriniz: ");
                sayi1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Bir sayı giriniz: ");
                sayi2 = Double.Parse(Console.ReadLine());
                işlemSonucu = sayi1 / sayi2;
                Console.WriteLine("{0}/{1}= {2}", sayi1, sayi2, işlemSonucu);


            }
            else
                Console.WriteLine("Geçersiz İşlem Numarası!!");



            Console.ReadLine();
        }
    }
}
