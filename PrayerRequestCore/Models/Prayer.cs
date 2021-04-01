using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PrayerRequestCore.Models
{
    public class Prayer
    {
        public Prayer()
        {
            Comments = new Collection<Comment>();
        }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int PrayedCount { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }    
    }
}
