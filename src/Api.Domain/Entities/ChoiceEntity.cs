using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class ChoiceEntity : BaseEntity
    {
        [Required]
        public string Choice { get; set; }
        public int QuestionId { get; set; }
    }
}
