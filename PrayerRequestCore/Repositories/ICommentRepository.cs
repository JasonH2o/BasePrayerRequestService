using PrayerRequestCore.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PrayerRequestCore.Repositories
{
    public interface ICommentRepository: IRepository<User>
    {
        Task<IEnumerable<User>> GetAllWithPrayerAsync();
        Task<User> GetWithPrayerByIdAsync(int id);
        Task<IEnumerable<User>> GetAllWithPrayerByPrayerIdAsync(int prayerId);

    }
}
