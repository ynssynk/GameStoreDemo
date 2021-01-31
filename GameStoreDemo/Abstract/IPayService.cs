using GameStoreDemo.Entities;

namespace GameStoreDemo.Abstract
{
    public interface IPayService
    {
        bool Purchase(User user);
    }
}