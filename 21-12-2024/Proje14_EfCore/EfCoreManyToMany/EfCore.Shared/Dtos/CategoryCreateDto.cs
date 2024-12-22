using System;

namespace EfCore.Shared.Dtos;

public class CategoryCreateDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsDeleted { get; set; }

}
