using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        private DateTime? _dateCreate;
        public DateTime? DateCreate
        {
            get { return _dateCreate; }
            set { _dateCreate = (value == null ? DateTime.UtcNow : value); }
        }
        public DateTime? DateUpdate { get; set; }
    }
}
