using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Xyami.Core.Entities
{
    public class Category
    {
        [Key]
        public long CategoryId { get; set; }
        [Required]
        public string Designaction { get; set; }

        public ICollection<Family> Families { get; set; }
    }
}
