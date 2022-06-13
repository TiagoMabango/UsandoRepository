using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xyami.Core.DTOs
{
    public class ProductDTO
    {
        public long ProductId { get; set; }
        public string Name { get; set; }
        public bool State { get; set; }
        public DateTime DateInsert { get; set; }

        public FamilyDTO Family { get; set; }
    }
    public class ProductCreatDTO
    {
        public long FamileId { get; set; }
        public string Name { get; set; }
    }
}
