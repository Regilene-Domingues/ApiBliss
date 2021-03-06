using Api.Data.Mapping;
using Api.Data.Seeds;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<ChoiceEntity> Choices { get; set; }
        public DbSet<QuestionEntity> Questions { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ChoiceEntity>(new ChoiceMap().Configure);
            modelBuilder.Entity<QuestionEntity>(new QuestionMap().Configure);

            TableQuestionSeeds.Questions(modelBuilder);
        }
    }
}
