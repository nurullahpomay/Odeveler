using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
       
        public void add (Musterı musterı)
        {
            Console.WriteLine("Müşteri başarıyla eklenidi---->" + musterı.name,musterı.Surname );
            Console.WriteLine("------- add işlemi bitti----");
        }
        
        public void delete(Musterı musterı )
        {
            Console.WriteLine("Müşteri başarıyla silindi---->" + musterı.name,musterı.Surname );
            Console.WriteLine("-------delete işlemi bitti -------");
        }
        
        public void listele(Musterı musterı)
        {
            Musterı musterı1 = new Musterı();
            musterı1.Id = 1;
            musterı1.name = "bugra";
            musterı1.Surname = "küpeli";

            Musterı musterı2 = new Musterı();
            musterı2.Id = 2;
            musterı2.name = "ersoy";
            musterı2.Surname = "altan";

            Musterı musterı3 = new Musterı();
            musterı3.Id = 1;
            musterı3.name = "nurullah";
            musterı3.Surname = "pomay";
            Musterı[] musteriler = new Musterı[] { musterı1 ,musterı2 ,musterı3 };
            foreach (Musterı musterıs in musteriler)
            {
                Console.WriteLine(musterıs.Id);
                Console.WriteLine(musterıs.name);
                Console.WriteLine(musterıs.Surname);
                Console.WriteLine("------------");
            }
            Console.WriteLine("------döngü bitti------------");
        }

    }
}
