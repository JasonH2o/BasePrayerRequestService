using System;
using System.Collections.Generic;
using System.Text;

namespace PrayerRequestCore.Repositories
{
    public interface IUnitOfWork: IDisposable
    {
        IUserRepository Users { get; }
        IPrayerRepository Prayers { get; }
        ICommentRepository Comments { get; }
    }
}
