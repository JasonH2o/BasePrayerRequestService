using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrayerRequestCore.Models;

namespace DataAccessLayer.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {  
            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.CommentDetail).IsRequired().HasMaxLength(300);

            builder.HasOne(x => x.Prayer)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.PrayerId);

            builder.ToTable("Comments");
        }
    }
}
