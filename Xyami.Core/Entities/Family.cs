using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Xyami.Core.Entities
{
    public class Family
    {
        [Key]
        public long FamilyId { get; set; }
        [ForeignKey("CategoryId")]
        public long CategoryId { get; set; }
        [Required]
        public string Designaction { get; set; }

        public Category Category { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
