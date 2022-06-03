using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Data.Context;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly MyContext _context;
        private DbSet<T> _dataset;
        public BaseRepository(MyContext context)
        {
            _context = context;
            _dataset = _context.Set<T>();
        }

        public async Task<T> SelectAsync(int id)
        {
            try
            {
                return await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<QuestionEntity> GetByIdAsync(int id)
        {
            try
            {
                var result = await _context.Questions.FirstOrDefaultAsync(x => x.Id.Equals(id));
                result.Choice = new List<ChoiceEntity>();
                var choices = new List<ChoiceEntity>();
                choices = await _context.Choices.Where(x => x.QuestionId == result.Id).ToListAsync();
                result.Choice.AddRange(choices);

                return result;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<T>> SelectAsync()
        {
            try
            {
                return await _dataset.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<QuestionEntity>> GetAllAsync()
        {
            try
            {

                var result = await _context.Questions.ToArrayAsync();


                foreach (var item in result)
                {
                    item.Choice = new List<ChoiceEntity>();
                    var choices = new List<ChoiceEntity>();
                    choices = await _context.Choices.Where(x => x.QuestionId == item.Id).ToListAsync();
                    item.Choice.AddRange(choices);
                }
                return result;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // public async Task<T> InsertAsync(T item)
        // {
        //     try
        //     {
        //         if (item.Id == Guid.Empty)
        //         {
        //             item.Id = Guid.NewGuid();
        //         }

        //         item.DateCreate = DateTime.UtcNow;
        //         _dataset.Add(item);

        //         await _context.SaveChangesAsync();

        //     }
        //     catch (Exception ex)
        //     {
        //         throw ex;
        //     }

        //     return item;
        // }

        // public async Task<T> UpdateAsync(T item)
        // {
        //     try
        //     {
        //         var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(item.Id));
        //         if (result == null)
        //             return null;

        //         item.DateUpdate = DateTime.UtcNow;
        //         item.DateCreate = result.DateCreate;

        //         _context.Entry(result).CurrentValues.SetValues(item);
        //         await _context.SaveChangesAsync();
        //     }
        //     catch (Exception ex)
        //     {
        //         throw ex;
        //     }

        //     return item;
        // }
        // public async Task<bool> DeleteAsync(Guid id)
        // {
        //     try
        //     {
        //         var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));        

        //         _dataset.Remove(result);
        //         await _context.SaveChangesAsync();
        //         return true;
        //     }
        //     catch (Exception ex)
        //     {
        //         throw ex;
        //     }
        // }
    }
}
