using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri customer)
        {
            Console.WriteLine("Müşteri eklendi :");
        }
        public void Delete(Musteri customer)
        {
            Console.WriteLine("Müşteri silindi.");
        }
        public void List(Musteri customer)
        {
            Console.WriteLine("Müşteri listelendi.");
        }
    }
}
