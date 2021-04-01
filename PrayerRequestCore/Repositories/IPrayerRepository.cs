using PrayerRequestCore.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PrayerRequestCore.Repositories
{
    public interface IPrayerRepository: IRepository<Prayer>
    {
        Task<IEnumerable<Prayer>> GetAllWithCommentsAsync();
        Task<Prayer> GetWithCommentsByIdAsync(int id);
        Task<IEnumerable<Prayer>> GetAllWithCommentsByUserId(int userId);

    }
}
