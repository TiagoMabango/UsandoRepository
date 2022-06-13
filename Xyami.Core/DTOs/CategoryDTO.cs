using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xyami.Core.DTOs
{
    public class CategoryDTOAll
    {
        public long CategoryId { get; set; }
        public string Designaction { get; set; }

        public ICollection<FamilyListDTO> Families { get; set; }
    }
    public class CategoryListDTO
    {
        public long CategoryId { get; set; }
        public string Designaction { get; set; }
    }
    public class CategoryDTO
    {
        public string Designaction { get; set; }
    }
}
