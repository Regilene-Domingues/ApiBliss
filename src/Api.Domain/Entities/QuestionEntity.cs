using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class QuestionEntity : BaseEntity
    {
        [Required]
        [MaxLength(200)]
        public string Question { get; set; }
        public virtual IEnumerable<ChoiceEntity> Choice { get; set; }
    }
}
