using System;
using System.Collections.Generic;
using GameStoreDemo.Abstract;
using GameStoreDemo.Entities;

namespace GameStoreDemo.Concrete
{
    public class CampaignManager:ICampaignService
    {
        
        public void GetList(List<Campaign> entities)
        {
            foreach (var entity in entities)
            {
                Console.WriteLine("Kampanyalar => {0}", entity.Name);
            }
        }

        public void Get(Campaign entity)
        {
            Console.WriteLine("Kampanya => {0}", entity.Name);
        }

        public void Add(Campaign entity)
        {
            Console.WriteLine("Yeni kampanya => {0}",entity.Name);
        }

        public void Update(Campaign entity)
        {
            Console.WriteLine("Kampanya bilgileri güncellendi => {0}", entity.Name);
        }

        public void Delete(Campaign entity)
        {
            Console.WriteLine("Kampanya silindi => {0}", entity.Name);
        }
    }
}