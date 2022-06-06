using System;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Seeds
{
    public static class TableQuestionSeeds
    {
        public static void Questions(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuestionEntity>().HasData(
            new QuestionEntity()
            {
                Id = 1,
                Question = "Question 1",
                DateCreate = DateTime.Now
            },
            new QuestionEntity()
            {
                Id = 2,
                Question = "Question 2",
                DateCreate = DateTime.Now
            },
            new QuestionEntity()
            {
                Id = 3,
                Question = "Question 3",
                DateCreate = DateTime.Now
            },
            new QuestionEntity()
            {
                Id = 4,
                Question = "Question 4",
                DateCreate = DateTime.Now
            },
            new QuestionEntity()
            {
                Id = 5,
                Question = "Question 5",
                DateCreate = DateTime.Now
            },
            new QuestionEntity()
            {
                Id = 6,
                Question = "Question 6",
                DateCreate = DateTime.Now
            },
            new QuestionEntity()
            {
                Id = 7,
                Question = "Question 7",
                DateCreate = DateTime.Now
            },
            new QuestionEntity()
            {
                Id = 8,
                Question = "Question 8",
                DateCreate = DateTime.Now
            },
            new QuestionEntity()
            {
                Id = 9,
                Question = "Question 9",
                DateCreate = DateTime.Now
            },
            new QuestionEntity()
            {
                Id = 10,
                Question = "Question 10",
                DateCreate = DateTime.Now
            },
            new QuestionEntity()
            {
                Id = 11,
                Question = "Question 11",
                DateCreate = DateTime.Now
            },
            new QuestionEntity()
            {
                Id = 12,
                Question = "Question 12",
                DateCreate = DateTime.Now
            },
            new QuestionEntity()
            {
                Id = 13,
                Question = "Question 13",
                DateCreate = DateTime.Now
            },
            new QuestionEntity()
            {
                Id = 14,
                Question = "Question 14",
                DateCreate = DateTime.Now
            },
            new QuestionEntity()
            {
                Id = 15,
                Question = "Question 15",
                DateCreate = DateTime.Now
            }
            );

            modelBuilder.Entity<ChoiceEntity>().HasData(
            new ChoiceEntity()
            {
                Id = 1,
                Choice = "Choice 1",
                DateCreate = DateTime.Now,
                QuestionId = 1
            },
            new ChoiceEntity()
            {
                Id = 2,
                Choice = "Choice 2",
                DateCreate = DateTime.Now,
                QuestionId = 2
            },
            new ChoiceEntity()
            {
                Id = 3,
                Choice = "Choice 3",
                DateCreate = DateTime.Now,
                QuestionId = 3
            },
            new ChoiceEntity()
            {
                Id = 4,
                Choice = "Choice 4",
                DateCreate = DateTime.Now,
                QuestionId = 4
            },
            new ChoiceEntity()
            {
                Id = 5,
                Choice = "Choice 5",
                DateCreate = DateTime.Now,
                QuestionId = 5
            },
            new ChoiceEntity()
            {
                Id = 6,
                Choice = "Choice 6",
                DateCreate = DateTime.Now,
                QuestionId = 6
            },
            new ChoiceEntity()
            {
                Id = 7,
                Choice = "Choice 7",
                DateCreate = DateTime.Now,
                QuestionId = 7
            },
            new ChoiceEntity()
            {
                Id = 8,
                Choice = "Choice 8",
                DateCreate = DateTime.Now,
                QuestionId = 8
            },
            new ChoiceEntity()
            {
                Id = 9,
                Choice = "Choice 9",
                DateCreate = DateTime.Now,
                QuestionId = 9
            },
            new ChoiceEntity()
            {
                Id = 10,
                Choice = "Choice 10",
                DateCreate = DateTime.Now,
                QuestionId = 10
            },
            new ChoiceEntity()
            {
                Id = 11,
                Choice = "Choice 11",
                DateCreate = DateTime.Now,
                QuestionId = 11
            },
            new ChoiceEntity()
            {
                Id = 12,
                Choice = "Choice 12",
                DateCreate = DateTime.Now,
                QuestionId = 12
            },
            new ChoiceEntity()
            {
                Id = 13,
                Choice = "Choice 13",
                DateCreate = DateTime.Now,
                QuestionId = 13
            },
            new ChoiceEntity()
            {
                Id = 14,
                Choice = "Choice 14",
                DateCreate = DateTime.Now,
                QuestionId = 14
            },
            new ChoiceEntity()
            {
                Id = 15,
                Choice = "Choice 15",
                DateCreate = DateTime.Now,
                QuestionId = 15
            }
            );
        }
    }
}
