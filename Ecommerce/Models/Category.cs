using System;
using System.Collections.Generic;

#nullable disable

namespace Ecommerce.Models
{
    public partial class Category
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string CategaryName { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string IsDeleted { get; set; }
        public string UpdatedBy { get; set; }
    }
}
