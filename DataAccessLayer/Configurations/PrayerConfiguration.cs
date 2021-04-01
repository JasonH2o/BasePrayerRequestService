using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrayerRequestCore.Models;

namespace DataAccessLayer.Configurations
{
    public class PrayerConfiguration : IEntityTypeConfiguration<Prayer>
    {
        public void Configure(EntityTypeBuilder<Prayer> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.UserName).IsRequired();

            builder.Property(x => x.Description).IsRequired();

            builder.HasOne(x => x.User)
                    .WithMany(x => x.Prayers)
                    .HasForeignKey(x => x.UserId);

            builder.ToTable("Prayers");
        }
    }
}
