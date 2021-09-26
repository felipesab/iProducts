using System;
using System.ComponentModel.DataAnnotations;

namespace CategoryService.Models
{
    public record Category
    {
        [Key]
        [Required]
        public int Id { get; init; }

        [Required]
        public string Name { get; init; }

        [Required]
        public DateTime CreateDate { get; init; }

    }
}