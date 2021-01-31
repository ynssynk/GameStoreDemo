using GameStoreDemo.Entities;

namespace GameStoreDemo.Abstract
{
    public interface IUserCheckService
    {
        bool ChechIfRealUser(User user);
    }
}