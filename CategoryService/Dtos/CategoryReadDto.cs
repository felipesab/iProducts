using System;

namespace CategoryService.Dtos
{
    public record CategoryReadDto
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public DateTime CreateDate { get; init; }
    }
}