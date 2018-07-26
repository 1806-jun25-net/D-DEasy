using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DandDEasy.Services
{
    public partial class DnDEasyContext : DbContext
    {

        public DnDEasyContext(DbContextOptions<DnDEasyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Campaign> Campaign { get; set; }
        public virtual DbSet<CampaignGraveyard> CampaignGraveyard { get; set; }
        public virtual DbSet<Character> Character { get; set; }
        public virtual DbSet<CharacterClasses> CharacterClasses { get; set; }
        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:schull-1806.database.windows.net,1433;Initial Catalog=DnDEasy;Persist Security Info=False;User ID=varnathin;Password=Kronehand2;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Campaign>(entity =>
            {
                entity.Property(e => e.CreationDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.DungeonMaster)
                    .WithMany(p => p.Campaign)
                    .HasForeignKey(d => d.DungeonMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Campaign__Dungeo__4E88ABD4");
            });

            modelBuilder.Entity<CampaignGraveyard>(entity =>
            {
                entity.HasIndex(e => e.CharacterId)
                    .HasName("UQ__Campaign__757BC9A175C915DA")
                    .IsUnique();

                entity.HasOne(d => d.Campaign)
                    .WithMany(p => p.CampaignGraveyard)
                    .HasForeignKey(d => d.CampaignId)
                    .HasConstraintName("FK__CampaignG__Campa__74AE54BC");

                entity.HasOne(d => d.Character)
                    .WithOne(p => p.CampaignGraveyard)
                    .HasForeignKey<CampaignGraveyard>(d => d.CharacterId)
                    .HasConstraintName("FK__CampaignG__Chara__75A278F5");
            });

            modelBuilder.Entity<Character>(entity =>
            {
                entity.Property(e => e.Alignment)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ArmorClass).HasDefaultValueSql("((0))");

                entity.Property(e => e.Background)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Charisma).HasDefaultValueSql("((8))");

                entity.Property(e => e.Constitution).HasDefaultValueSql("((8))");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dexterity).HasDefaultValueSql("((8))");

                entity.Property(e => e.Experience).HasDefaultValueSql("((0))");

                entity.Property(e => e.HitPoints).HasDefaultValueSql("((0))");

                entity.Property(e => e.Intelligence).HasDefaultValueSql("((8))");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Race)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Strength).HasDefaultValueSql("((8))");

                entity.Property(e => e.Wisdom).HasDefaultValueSql("((8))");

                entity.HasOne(d => d.Campaign)
                    .WithMany(p => p.Character)
                    .HasForeignKey(d => d.CampaignId)
                    .HasConstraintName("FK__Character__Campa__5BE2A6F2");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Character)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Character__UserI__5AEE82B9");
            });

            modelBuilder.Entity<CharacterClasses>(entity =>
            {
                entity.HasOne(d => d.Character)
                    .WithMany(p => p.CharacterClasses)
                    .HasForeignKey(d => d.CharacterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Character__Chara__787EE5A0");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.CharacterClasses)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Character__Class__797309D9");
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.HasIndex(e => e.ClassName)
                    .HasName("UQ__Class__F8BF561BE6A422C2")
                    .IsUnique();

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HitDice)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Username)
                    .HasName("UQ__User__536C85E4A5A278AC")
                    .IsUnique();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });
        }
    }
}
