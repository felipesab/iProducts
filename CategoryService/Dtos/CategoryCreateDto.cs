using System;
using System.ComponentModel.DataAnnotations;

namespace CategoryService.Dtos
{
    public class CategoryCreateDto
    {
        [Required]
        public string Name { get; init; }

        [Required]
        public DateTime CreateDate { get; init; }
    }
}