using System;
using GameStoreDemo.Abstract;
using GameStoreDemo.Entities;

namespace GameStoreDemo.Adapters
{
    public class MobilPayAdapter:IPayService
    {
        public bool Purchase(User user)
        {
            Console.WriteLine("Mobil ödeme başarılı"+user.FirstName);
            return true;
        }
    }
}