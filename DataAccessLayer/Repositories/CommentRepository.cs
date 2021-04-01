using Microsoft.EntityFrameworkCore;
using PrayerRequestCore.Models;
using PrayerRequestCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        public CommentRepository(PrayerDbContext context):base(context)
        {
        }

        private PrayerDbContext PrayerDbContext
        {
            get { return Context as PrayerDbContext; }
        }

        public Task AddAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public Task AddRangeAsync(IEnumerable<User> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> Find(Expression<Func<User, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllWithPrayerAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllWithPrayerByPrayerIdAsync(int prayerId)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetWithPrayerByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task PutAsync(int id, User entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(User entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<User> entities)
        {
            throw new NotImplementedException();
        }

        public Task<User> SingleOrDefaultAsync(Expression<Func<User, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<User>> IRepository<User>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        ValueTask<User> IRepository<User>.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
