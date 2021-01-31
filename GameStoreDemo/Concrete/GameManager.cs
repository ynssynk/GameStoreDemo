using System;
using System.Collections.Generic;
using GameStoreDemo.Abstract;
using GameStoreDemo.Entities;

namespace GameStoreDemo.Concrete
{
    public class GameManager:IGameService
    {
        public void GetList(List<Game> entities)
        {
            foreach (var entity in entities)
            {
                Console.WriteLine("Oyunlar => Oyun adı: {0}\nOyun AÇıklması {1}\nFiyat: {2}\nOyun Yayıncısı: {3}", entity.Name, entity.Description, entity.Price, entity.Publisher);
            }
        }

        public void Get(Game entity)
        {
            Console.WriteLine("Oyun adı: {0}\nOyun AÇıklması {1}\nFiyat: {2}\nOyun Yayıncısı: {3}", entity.Name, entity.Description, entity.Price, entity.Publisher);
        }

        public void Add(Game entity)
        {
            Console.WriteLine("Yeni oyun eklendi => Oyun adı: {0}\nOyun AÇıklması {1}\nFiyat: {2}\nOyun Yayıncısı: {3}",entity.Name,entity.Description,entity.Price,entity.Publisher);
        }

        public void Update(Game entity)
        {
            Console.WriteLine("Oyun bilgileri güncellendi => Oyun adı: {0}\nOyun AÇıklması {1}\nFiyat: {2}\nOyun Yayıncısı: {3}", entity.Name, entity.Description, entity.Price, entity.Publisher);
        }

        public void Delete(Game entity)
        {
            Console.WriteLine("Oyun silindi => Oyun adı: {0}\nOyun AÇıklması {1}\nFiyat: {2}\nOyun Yayıncısı: {3}", entity.Name, entity.Description, entity.Price, entity.Publisher);
        }
    }
}