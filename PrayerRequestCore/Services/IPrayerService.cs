using PrayerRequestCore.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PrayerRequestCore.Services
{
    public interface IPrayerService
    {
        Task<IEnumerable<Prayer>> GetAllPrayers();
        Task<Prayer> GetPrayerById(int id);
        Task<Prayer> CreatePrayer(Prayer newPrayer);
        Task UpdatePrayer(Prayer PrayerToBeUpdated, Prayer prayer);
        Task DeletePrayer(Prayer prayer);
    }
}
