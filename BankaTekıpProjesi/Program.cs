using ClassMetotDemo;
using System;

namespace BankaTekıpProjesi
{
    class Program
    {
        static void Main(string[] args)
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

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.add(musterı1);
            musteriManager.delete(musterı2);
            musteriManager.listele(musterı3);
        }
    }
}
