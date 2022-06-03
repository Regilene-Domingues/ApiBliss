using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class QuestionEntity : BaseEntity
    {
        [Required]
        [MaxLength(200)]
        public string Question { get; set; }
        public virtual List<ChoiceEntity> Choice { get; set; }
    }
}
