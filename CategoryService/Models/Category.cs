using System;
using System.ComponentModel.DataAnnotations;

namespace CategoryService.Models
{
    public record Category
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

    }
}