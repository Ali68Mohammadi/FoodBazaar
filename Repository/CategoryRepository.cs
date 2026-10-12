using FoodBazaar.Data;
using FoodBazaar.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace FoodBazaar.Repository
{
    public class CategoryRepository(ApplicationDbContext db) : ICategoryRepository
    {

        public async Task<Category> CreateAsync(Category category)
        {
            await db.AddAsync(category);
            await db.SaveChangesAsync();
            return category;
        }


        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await db.Category.FindAsync(id);
            if (entity == null) return false;
            db.Remove(entity);
            await db.SaveChangesAsync();
            return true;
        }

        public async Task<Category> GetAsync(int id)
        {
            var entity = await db.Category.FindAsync(id);
            if (entity == null)
            { 
                return new Category();
            }
            return entity;
        }


        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await db.Category.ToListAsync();
        }


        public async Task<Category> UpdateAsync(Category category)
        {
            var catergoryFromBd = await db.Category.FindAsync(category.Id);
            if (catergoryFromBd is not null)
            {
                catergoryFromBd.Name = category.Name;
                db.Category.Update(catergoryFromBd);
                await db.SaveChangesAsync();
                return catergoryFromBd;
            }
            return category;
        }

        public async Task<bool> IsExistAsync(int id)
        {
            var entity = await db.Category.FindAsync(id);
            return entity != null;
        }

    }

}
