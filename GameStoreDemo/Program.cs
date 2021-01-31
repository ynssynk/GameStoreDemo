using System;
using System.Collections.Generic;
using GameStoreDemo.Abstract;
using GameStoreDemo.Adapters;
using GameStoreDemo.Concrete;
using GameStoreDemo.Entities;

namespace GameStoreDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User()
            {
                Id = 1,FirstName = "Yunus",LastName = "Yanık",DateOfYear = 1993,UserName = "yanikyunus",NationalityId = 12345
            };
            
            UserManager userManager = new UserManager(new UserCheckManager());
            userManager.Add(user1);
            Game game1 = new Game
            {
                CategoryId = 1,Description = "FPS",Developer = "SpaceY",Id = 1,Name = "Space Killer",Price = 15,Publisher = "SpaceY",ReleaseDate =new DateTime(2021)
            };
            CartManager cartManager = new CartManager(new MobilPayAdapter());
            cartManager.AddtoCart(game1,1);
            cartManager.Purchase(user1);

            

        }
    }
}
