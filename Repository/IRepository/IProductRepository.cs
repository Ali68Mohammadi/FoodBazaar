using FoodBazaar.Data;

namespace FoodBazaar.Repository.IRepository
{
    public interface IProductRepository
    {
        Task<Product> CreateAsync(Product product);
        Task<Product> UpdateAsync(Product product);
        Task<bool> DeleteAsync(int id);
        Task<Product> GetAsync(int id);
        Task<IEnumerable<Product>> GetAllAsync();
        Task<(IEnumerable<Product> Items, int TotalCount)> GetProductsByCategoryAsync
            (string searchString,  int categoryId, int pageNumber , int pageSize );
        Task<bool> IsExistAsync(int id);
    }
}