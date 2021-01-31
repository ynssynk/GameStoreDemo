using System;
using System.Collections.Generic;
using GameStoreDemo.Abstract;
using GameStoreDemo.Entities;

namespace GameStoreDemo.Concrete
{
    public class UserManager:IUserService
    {
        private IUserCheckService _userCheckService;

        public UserManager(IUserCheckService userCheckService)
        {
            _userCheckService = userCheckService;
        }

        public void GetList(List<User> entities)
        {
            foreach (var entity in entities)
            {
                Console.WriteLine("Ad - Soyad: {0} - {1}\nKullanıcı Adı: {2}",entity.FirstName,entity.LastName,entity.UserName);
            }
        }

        public void Get(User entity)
        {
            Console.WriteLine(entity.UserName);
        }

        public void Add(User entity)
        {
            if (_userCheckService.ChechIfRealUser(entity))
            {
                Console.WriteLine("Save to user: {0}",entity.UserName);
            }
            else
            {
                Console.WriteLine("Not a valid user");
            }
        }

        public void Update(User entity)
        {
            if (entity != null) Console.WriteLine("Kullanıcı bilgileri güncellendi {0}", entity.UserName);
        }

        public void Delete(User entity)
        {
           if(entity!=null)  Console.WriteLine("Kullanıcı bilgileri silindi {0}",entity.UserName);
        }
    }
}