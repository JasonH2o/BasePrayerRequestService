using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PrayerRequestCore.Models
{
    public class User
    {
        public User()
        {
            Prayers = new Collection<Prayer>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Prayer> Prayers { get; set; }
    }
}
