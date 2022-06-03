using System;
using System.Collections.Generic;
using System.Linq;
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

            // modelBuilder.Entity<QuestionEntity>().HasData(
            //   new QuestionEntity()
            //   {
            //       Id = 1,
            //       Question = "Question 1",
            //       DateCreate = DateTime.Now
            //   });


            // modelBuilder.Entity<ChoiceEntity>().HasData(
            //     new ChoiceEntity()
            //     {
            //         Id = 1,
            //         Choice = "Choice 1",
            //         DateCreate = DateTime.Now,
            //         QuestionId = 1
            //     });


            TableQuestionSeeds.Questions(modelBuilder);
        }

        //     protected override void OnModelCreating(ModelBuilder modelBuilder)
        //     {
        //         var questionId1 = Guid.NewGuid();
        //         var questionId2 = Guid.NewGuid();
        //         var questionId3 = Guid.NewGuid();
        //         base.OnModelCreating(modelBuilder);

        //         modelBuilder.Entity<ChoiceEntity>(new ChoiceMap().Configure);
        //         modelBuilder.Entity<QuestionEntity>(new QuestionMap().Configure);

        //         modelBuilder.Entity<QuestionEntity>().HasData(
        //             new QuestionEntity
        //             {
        //                 Id = questionId1,
        //                 Question = "Quando mudar o projeto?",
        //                 DateCreate = DateTime.Now,
        //                 DateUpdate = DateTime.Now,
        //                 Choice = new List<ChoiceEntity>()
        //                 {
        //                         new ChoiceEntity {
        //                            Id = Guid.NewGuid(),
        //                            Choice ="Quando mudar o projeto",
        //                            DateCreate = DateTime.Now,
        //                            DateUpdate = DateTime.Now,
        //                            }
        //                 }
        //             });

        //         //modelBuilder.Entity<ChoiceEntity>().HasData(
        //         //    new ChoiceEntity { 
        //         //    Id = Guid.NewGuid(),
        //         //    Choice ="Quando mudar o projeto",
        //         //    DateCreate = DateTime.Now,
        //         //    DateUpdate = DateTime.Now,                
        //         //    }
        //         //    , new ChoiceEntity
        //         //    {
        //         //        Id = Guid.NewGuid(),
        //         //        Choice = "Quando mudar voc� trabalhar",
        //         //        DateCreate = DateTime.Now,
        //         //        DateUpdate = DateTime.Now
        //         //    },
        //         //    new ChoiceEntity
        //         //    {
        //         //        Id = Guid.NewGuid(),
        //         //        Choice = "Quando a xuxa aparecer",
        //         //        DateCreate = DateTime.Now,
        //         //        DateUpdate = DateTime.Now
        //         //    },
        //         //    new ChoiceEntity
        //         //    {
        //         //        Id = Guid.NewGuid(),
        //         //        Choice = "Quando a sacha apresentar o show da xuxa",
        //         //        DateCreate = DateTime.Now,
        //         //        DateUpdate = DateTime.Now
        //         //    },
        //         //    new ChoiceEntity
        //         //    {
        //         //        Id = Guid.NewGuid(),
        //         //        Choice = "quando o brasil/palmeiras ganhar o mundial",
        //         //        DateCreate = DateTime.Now,
        //         //        DateUpdate = DateTime.Now
        //         //    });



        //     }
    }
}
