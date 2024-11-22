namespace Infrastructure.Data.Configurations.EntityConfigrations
{
    internal class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.Property(x => x.Key).HasMaxLength(256);
            builder.Property(x => x.Description).HasMaxLength(2000);
        }
    }
}
