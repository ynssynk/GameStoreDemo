using System;
using GameStoreDemo.Abstract;
using GameStoreDemo.Entities;

namespace GameStoreDemo.Concrete
{
    public class UserCheckManager:IUserCheckService
    {
        public bool ChechIfRealUser(User user)
        {
            return true;
        }
    }
}