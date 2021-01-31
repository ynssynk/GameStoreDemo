using System;
using GameStoreDemo.Abstract;
using GameStoreDemo.Entities;

namespace GameStoreDemo.Concrete
{
    public class CreditCardPayManager:IPayService
    {
        public bool Purchase(User user)
        {
            Console.WriteLine("Ödeme Credi kartı ile yapıldı");
            return true;
        }
    }
}