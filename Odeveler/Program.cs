using System;

namespace Odeveler
{
    class Program
    {
        private static object product;

        static void Main(string[] args)
        {
            Pruduct pruduct1 = new Pruduct();
            pruduct1.adı = "klavye";
            pruduct1.fıyat = 50;
            pruduct1.turu = "bilgisayar teknolojileri";

            Pruduct pruduct2 = new Pruduct();
            pruduct2.adı = "monitör";
            pruduct2.fıyat = 2500;
            pruduct2.turu = "bilgisayar teknolojileri";

            Pruduct pruduct3 = new Pruduct();
            pruduct3.adı = "fare";
            pruduct3.fıyat = 50;
            pruduct3.turu = "bilgisayar teknolojileri";

            Pruduct[] pruducts = new Pruduct[] {pruduct1,pruduct2,pruduct3};

            for (int i = 0; i <pruducts.Length; i++)
            {
                Console.WriteLine(pruducts[i].adı +"   fiyatı = "+ pruducts[i].fıyat + "   türü : " + pruducts[i].turu);
            }
            Console.WriteLine( " ---------for bitti------ " );
            foreach (var pruduct in pruducts)
            {
                Console.WriteLine(pruduct.adı);
                Console.WriteLine(pruduct.fıyat);
                Console.WriteLine(pruduct.turu);
            }
            Console.WriteLine("------foreach bitti-------");
            int k = 0;
            while (k < pruducts.Length)
            {
                Console.WriteLine(pruducts[k].adı);
                Console.WriteLine(pruducts[k].fıyat);
                Console.WriteLine(pruducts[k].turu);
               

                k++;
            }
            Console.WriteLine("------- while bitti -------");


        }
           


        class Pruduct
        {
            public string adı { get; set; }
            public int fıyat { get; set; }
            public string turu { get; set; }
        }
    }
}
