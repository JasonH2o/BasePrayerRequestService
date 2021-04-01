using PrayerRequestCore.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PrayerRequestCore.Services
{
    public interface ICommentService
    {
        Task<IEnumerable<User>> GetAllWithPrayer();
        Task<User> GetCommentById(int id);
        Task<IEnumerable<User>> GetCommentsByPrayerId(int artistId);
        Task<User> CreateComment(User newComment);
        Task UpdateComment(User commentToBeUpdated, User comment);
        Task DeleteComment(User comment);
    }
}
