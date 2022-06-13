using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xyami.Core.DTOs
{
    public class FamilyDTO
    {
        public long FamilyId { get; set; }
        public string Designaction { get; set; }
        public CategoryListDTO Category { get; set; }
    }
    public class FamilyListDTO
    {
        public long FamilyId { get; set; }
        public string Designaction { get; set; }
    }
    public class FamilyCreatDTO
    {
        public long CategoryId { get; set; }
        public string Designaction { get; set; }
    }
}
