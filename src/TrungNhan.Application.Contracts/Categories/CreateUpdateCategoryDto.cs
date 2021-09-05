using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TrungNhan.Categories
{
    public class CreateUpdateCategoryDto
    {
        [Required]
        [StringLength(250)]
        public string Name { get; set; }
        public CategoryType Type { get; set; }
    }
}
