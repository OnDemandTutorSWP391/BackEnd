using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace OnDemandTutorApi.DataAccessLayer.Entity
{
    public class MyDbContext : IdentityDbContext<User>
    {
        public MyDbContext()
        {
            
        }

        public MyDbContext(DbContextOptions<MyDbContext> option) : base(option) 
        {
            
        }

        #region DbSet
        public DbSet<User> Users {  get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("dbo");

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable(name: "Users");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("UserId");
                entity.Property(e => e.FullName)
                      .IsRequired()
                      .HasMaxLength(150)
                      .HasColumnName("FullName");
                entity.Property(e => e.IdentityCard)
                      .IsRequired()
                      .HasColumnName("Identity Card");
                entity.Property(e => e.Gender)
                      .IsRequired()
                      .HasColumnName("Gender");
                entity.Property(e => e.Dob)
                       .HasColumnName("Dob");
                entity.Property(e => e.CreatedDate)
                      .HasDefaultValueSql("getutcdate()")
                      .HasColumnName("CreatedDate");
                entity.Property(e => e.Status)
                      .HasColumnName("Status");
                entity.Property(e => e.Email)
                      .IsRequired()
                      .HasMaxLength(256)
                      .HasColumnName("Email");
                entity.Property(e => e.UserName)
                      .IsRequired()
                      .HasMaxLength(100)
                      .HasColumnName("UserName");
                entity.Property(e => e.PasswordHash)
                      .IsRequired()
                      .HasColumnName("Password");
                entity.Property(e => e.PhoneNumber)
                      .HasMaxLength(10)
                      .HasColumnName("Phone");
            });



            modelBuilder.Entity<IdentityUserRole<string>>(entity => { entity.ToTable(name: "UserRoles"); });


            modelBuilder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Roles");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("RoleId");
                entity.Property(e => e.Name)
                      .HasMaxLength(100)
                      .HasColumnName("RoleName");
            });


        }
    }
}
