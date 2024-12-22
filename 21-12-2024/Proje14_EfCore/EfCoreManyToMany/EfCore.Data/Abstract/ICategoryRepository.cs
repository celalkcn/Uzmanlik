using System;
using EfCore.Entity.Concrete;

namespace EfCore.Data.Abstract;

public interface ICategoryRepository:IGenericRepository<Category>
{
 Task<IEnumerable<Category>> GetAllActiveCategoriesAsync(bool isDeleted=true);
}
