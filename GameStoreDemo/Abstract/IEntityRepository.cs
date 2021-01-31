using System.Collections.Generic;

namespace GameStoreDemo.Abstract
{
    public interface IEntityRepository<TEntity> where TEntity:IEntity
    {
        void GetList(List<TEntity> entities);
        void Get(TEntity entity);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}