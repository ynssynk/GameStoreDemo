using System;
using GameStoreDemo.Abstract;

namespace GameStoreDemo.Entities
{
    public class Campaign:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartOfDate { get; set; }
        public DateTime EndOfDate { get; set; }
        public int PercentageOfDiscount { get; set; }
    }
}