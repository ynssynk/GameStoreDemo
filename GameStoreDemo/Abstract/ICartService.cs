using System;
using GameStoreDemo.Entities;

namespace GameStoreDemo.Abstract
{
    public interface ICartService
    {
        void Purchase(User user);
        void AddtoCart(Game game,int quantity);
        
        void RemoveFromCart(Game game);

    }
}