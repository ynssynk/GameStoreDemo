using System;
using GameStoreDemo.Abstract;

namespace GameStoreDemo.Entities
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public long NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public int DateOfYear { get; set; }
        
    }
}