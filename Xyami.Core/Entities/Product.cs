using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xyami.Core.Entities
{
    public class Product
    {
        [Key]
        public long ProductId { get; set; }

        [ForeignKey("FamilyId")]
        public long FamilyId { get; set; }
        [Required]
        public string Name { get; set; }
        public bool State { get; set; }
        public DateTime DateInsert { get; set; }

        public Family Family { get; set; }
    }
}
