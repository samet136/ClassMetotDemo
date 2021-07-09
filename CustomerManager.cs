using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri Hesabı Eklendi : "+customer.Adi);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri Hesabı Silindi : "+customer.Adi);
        }
    }
}
