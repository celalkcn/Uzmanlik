using System;
using EfCore.Business.Abstract;
using EfCore.Data.Abstract;
using EfCore.Entity.Concrete;
using EfCore.Shared.Dtos;

namespace EfCore.Business.Concrete;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<ProductDto> CreateAsync(ProductCreateDto productCreateDto)
    {
        var product = new Product
        {
            Name = productCreateDto.Name,
            Price = productCreateDto.Price,
            Properties = productCreateDto.Properties
        };
        await _productRepository.AddAsync(product);
        product.ProductCategories = 
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ProductDto> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ProductDto>> GetProductsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ProductDto>> GetProductsAsync(bool isDeleted)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ProductDto>> GetProductsByCategoryAsync(int categoryId)
    {
        throw new NotImplementedException();
    }

    public Task<ProductDto> UpdateAsync(ProductUpdateDto productUpdateDto)
    {
        throw new NotImplementedException();
    }
}
