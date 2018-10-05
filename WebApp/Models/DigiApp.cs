namespace WebApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DigiApp : DbContext
    {
        public DigiApp()
            : base("name=DigiApp")
        {
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Chapter> Chapters { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }
        public virtual DbSet<Entity> Entities { get; set; }
        public virtual DbSet<QuizesData> QuizesDatas { get; set; }
        public virtual DbSet<Quizes> Quizes { get; set; }
        public virtual DbSet<QuizesResponse> QuizesResponses { get; set; }
        public virtual DbSet<QuizesOption> QuizesOptions { get; set; }
        public virtual DbSet<QuizesQuestionsLk> QuizesQuestionsLks { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Enrollment>()
                .Property(e => e.Fees)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Entity>()
                .Property(e => e.Gender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Entity>()
                .Property(e => e.Entity_Type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cart>()
                 .Property(e => e.Price)
                 .HasPrecision(19, 4);

            modelBuilder.Entity<Cart>()
                .Property(e => e.Discount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Txn_Amt)
                .HasPrecision(19, 4);
        }
    }
}
