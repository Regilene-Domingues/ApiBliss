using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class ChoiceEntity : BaseEntity
    {
        [Required]
        public string Choice { get; set; }
        public Guid QuestionId { get; set; }
        public virtual QuestionEntity Questions { get; set; }
    }
}
