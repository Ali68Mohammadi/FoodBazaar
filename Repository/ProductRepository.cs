using FoodBazaar.Data;
using FoodBazaar.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace FoodBazaar.Repository
{
    public class ProductRepository(ApplicationDbContext db, IWebHostEnvironment webHostEnvironment) : IProductRepository
    {

        public async Task<Product> CreateAsync(Product product)
        {
            await db.AddAsync(product);
            await db.SaveChangesAsync();
            return product;
        }


        public async Task<bool> DeleteAsync(int id)
        {

            var entity = await db.Product.FindAsync(id);
            var imagePath = Path.Combine(webHostEnvironment.WebRootPath, entity.ImageUrl.TrimStart('/'));
            if (entity == null) return false;
            if (File.Exists(imagePath))
            {
                File.Delete(imagePath);
            }
            db.Remove(entity);
            await db.SaveChangesAsync();
            return true;
        }

        public async Task<Product> GetAsync(int id)
        {
            var entity = await db.Product.FindAsync(id);
            if (entity == null)
            {
                return new Product();
            }
            return entity;
        }


        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await db.Product.Include(u => u.Category).ToListAsync();
        }


        public async Task<Product> UpdateAsync(Product product)
        {
            var productFromDb = await db.Product.FindAsync(product.Id);
            if (productFromDb is not null)
            {
                productFromDb.Name = product.Name;
                productFromDb.Price = product.Price;
                productFromDb.Description = product.Description;
                productFromDb.SpecialTag = product.SpecialTag;
                productFromDb.ImageUrl = product.ImageUrl;
                productFromDb.CategoryId = product.CategoryId;
                db.Product.Update(productFromDb);
                await db.SaveChangesAsync();
                return productFromDb;
            }
            return product;
        }

        public async Task<bool> IsExistAsync(int id)
        {
            var entity = await db.Product.FindAsync(id);
            return entity != null;
        }

    }

}
