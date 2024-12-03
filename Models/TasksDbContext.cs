using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using static System.Reflection.Metadata.BlobBuilder;

namespace Tasks.Models
{
    //public class TasksDbContext : DbContext
    //{

    //    public TasksDbContext(DbContextOptions<TasksDbContext> options) : base(options)
    //    {

    //    }

    //    //public DbSet<TasksModel> TasksModel { get; set; }
    //    public DbSet<TasksModel> TasksModel { get; set; }

    //}

    public partial class TasksDbContext : DbContext
    {
        public TasksDbContext()
        {
        }

        public TasksDbContext(DbContextOptions<TasksDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TasksModel> Tasks { get; set; }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Project> AttachmentsTasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<TasksModel>(entity =>
            //{
            //    entity.HasKey(x => x.TaskId);

            //    entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");
            //    entity.Property(e => e.Description)
            //        .HasMaxLength(500)
            //        .IsUnicode(false);
            //    entity.Property(e => e.Title)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);
            //    entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");

            //    entity.HasOne(d => d.User).WithMany(p => p.Tasks)
            //        .HasForeignKey(d => d.UserId)
            //        .HasConstraintName("fk_UserToTask");
            //});

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.id);

                //entity.Property(e => e.Email)
                //    .HasMaxLength(100)
                //    .IsUnicode(false);
                entity.Property(e => e.UserFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.UserLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                //entity.Property(e => e.Role)
                //    .HasMaxLength(20)
                //    .IsUnicode(false);
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(e => e.id);


            });


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}

