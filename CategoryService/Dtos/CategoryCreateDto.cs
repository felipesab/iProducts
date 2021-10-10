using System;
using System.ComponentModel.DataAnnotations;

namespace CategoryService.Dtos
{
    public class CategoryCreateDto
    {
        [Required]
        public string Name { get; init; }

        public DateTime CreateDate { get; set; }
    }
}