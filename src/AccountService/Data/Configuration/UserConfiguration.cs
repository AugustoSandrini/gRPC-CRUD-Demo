using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Service.Data.Models;

namespace Service.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(user => new { user.Id });

            builder.Property(c => c.Name).HasMaxLength(255);
            builder.Property(c => c.Email).HasMaxLength(255);
            builder.Property(c => c.Password).IsRequired();
        }
    }
}
