using Microsoft.EntityFrameworkCore;
using PrayerRequestCore.Models;
using PrayerRequestCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class PrayerRepository : Repository<Prayer>, IPrayerRepository
    {
        public PrayerRepository(PrayerDbContext context): base(context) { }

        public async Task<IEnumerable<Prayer>> GetAllWithCommentsAsync()
        {
            return await PrayerDbContext.Prayers.Include(x => x.Comments).ToListAsync();
        }
        //TODO: finish this up
        public Task<IEnumerable<Prayer>> GetAllWithCommentsByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<Prayer> GetWithCommentsByIdAsync(int id)
        {
            return PrayerDbContext.Prayers.Include(x => x.Comments).SingleOrDefaultAsync(x => x.Id == id);
        }

        private PrayerDbContext PrayerDbContext
        {
            get { return Context as PrayerDbContext; }
        }
    }
}
