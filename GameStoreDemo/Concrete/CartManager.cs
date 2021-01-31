using System;
using System.Collections.Generic;
using System.Linq;
using GameStoreDemo.Abstract;
using GameStoreDemo.Entities;

namespace GameStoreDemo.Concrete
{
    public class CartManager:ICartService
    {
        private IPayService _payService;

        
        private List<Cart> _carts = new List<Cart>();

        public CartManager(IPayService payService)
        {
            _payService = payService;
        }

        public void Purchase(User user)
        {
            if (_payService.Purchase(user))
            {
                Console.WriteLine("Ödeme başarılı");
            }
        }

        public void AddtoCart(Game game, int quantity)
        {
            Console.WriteLine("Sepete eklendi"+game.Name);
        }

        public void RemoveFromCart(Game game)
        {
            Console.WriteLine("Sepetten kaldırıldı" + game.Name);
        }

    }
}