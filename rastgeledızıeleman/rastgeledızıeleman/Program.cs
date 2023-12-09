

/*

class Program
{
    public static void Main(string[] args)
    {
        Random rastgele = new Random();//Random sınıfından rastgele isimli yeni bir nesne bildiriliyor.
        int a;
        int[] B = new int[10];
        for (a = 0; a < B.Length; a++)
        {
            B[a] = rastgele.Next(10, 51);//10 – 50 arasında rastgele sayı üretilir ve B[a] ya atanır.
            Console.WriteLine(a + ". Sayı = " + B[a]);
        }
        Console.Write("Press any key to continue . . . ");
        Console.ReadKey(true);
    }
}
*/

using System;

namespace or096  //-------------------foreach ıle tekrar yazımı
{
    class Program
    {
        public static void Main(string[] args)
        {
            double[] a = { 150, 600, 700, 450, 850, 275, 950, 1500, 210, 368 };

            foreach (double burs in a)
            {
                if (burs >= 500)
                {
               
                    Console.WriteLine(burs);
                    continue; 
                }

                // Burs miktarı 500'den küçükse artış yapılır.
                double yeniBurs = (burs * 0.1) + burs;
                yeniBurs = yeniBurs + 50;

                Console.WriteLine(yeniBurs);
            }

            Console.Write("DEVAM ETMEK İÇİN BİR TUŞA BASINIZ. . . ");
            Console.ReadKey(true);
        }
    }
}
