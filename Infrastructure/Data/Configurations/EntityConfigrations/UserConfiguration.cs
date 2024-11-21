namespace Infrastructure.Data.Configurations.EntityConfigrations
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(s => s.FirstName).HasMaxLength(100);
            builder.Property(s => s.LastName).HasMaxLength(100);
            builder.Property(s => s.DisplayName).HasMaxLength(100);
            builder.Property(s => s.OneTimeRegistrationDate).HasMaxLength(50);

            builder.Property(s => s.Email).HasMaxLength(100).IsRequired();
            builder.Property(s => s.NormalizedEmail).HasMaxLength(100);
            builder.Property(s => s.PasswordHash).HasMaxLength(200);
            builder.Property(s => s.SecurityStamp).HasMaxLength(50);
            builder.Property(s => s.ConcurrencyStamp).HasMaxLength(50);
            builder.Property(s => s.PhoneNumber).HasMaxLength(50);
        }
    }
}
