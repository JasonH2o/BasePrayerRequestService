using System;
using System.Collections.Generic;
using System.Text;

namespace PrayerRequestCore.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string CommentDetail { get; set; }
        public int PrayerId { get; set; }
        public Prayer Prayer { get; set; }
    }
}
