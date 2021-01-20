using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri customer1 = new Musteri();
            customer1.Adi = "Ömer";
            customer1.Soyadi = " Aran";
            customer1.Id = 101010;
            customer1.KrediNotu = 53;

            Musteri customer2 = new Musteri();
            customer2.Adi = "Metin";
            customer2.Soyadi = "Kaim";
            customer2.Id = 202020;
            customer2.KrediNotu = 69;

            Musteri customer3 = new Musteri();
            customer3.Adi = "Musab";
            customer3.Soyadi = "Ayan";
            customer3.Id = 303030;
            customer3.KrediNotu = 89;

            Musteri customer4 = new Musteri();
            customer4.Adi = "Emin";
            customer4.Soyadi = "Demir";
            customer4.Id = 404040;
            customer4.KrediNotu = 99;

            MusteriManager customermanager = new MusteriManager();

            Musteri[] customers = new Musteri[] {customer1,customer2,customer3,customer4};

            foreach (Musteri customer in customers)
            {
                Console.WriteLine(customer.Adi);
                Console.WriteLine(customer.Soyadi);
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.KrediNotu);
                customermanager.List(customer);
                Console.WriteLine("***************************");
               
            }

            customermanager.Add(customer1);
            customermanager.Add(customer2);
            customermanager.Add(customer3);
            customermanager.Delete(customer4);
        }
    }
}
