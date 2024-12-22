using System;
using EfCore.Shared.Dtos;


namespace EfCore.Business.Abstract;

public interface ICategoryService
{
 Task<CategoryDto> CreateAsync(CategoryCreateDto categoryCreateDto);
 Task<CategoryDto> UpdateAsync(CategoryUpdateDto categoryUpdateDto);
 Task DeleteAsnyc(int id);
 Task<IEnumerable<CategoryDto>> GetCategoriesAsync(bool isDeleted);
 Task<CategoryDto> GetByIdAsnyc(int id);                
}
