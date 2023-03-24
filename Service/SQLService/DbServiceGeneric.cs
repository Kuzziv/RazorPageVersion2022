using Microsoft.EntityFrameworkCore;
using RazorPageVersion2022.EFDbContext;
using RazorPageVersion2022.Service.Interfaces;

namespace RazorPageVersion2022.Service.SQLService
{
    public class DbServiceGeneric<T> : IService<T> where T : class
    {
        public async Task<IEnumerable<T>> GetObjectsAsync()
        {
            using (var context = new ItemDbContext())
            {
                return await context.Set<T>().AsNoTracking().ToListAsync();
            }
        }

        public async Task AddObjectAsync(T obj)
        {
            using (var context = new ItemDbContext())
            {
                context.Set<T>().Add(obj);
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteObjectAsync(T obj)
        {
            using (var context = new ItemDbContext())
            {
                context.Set<T>().Remove(obj);
                await context.SaveChangesAsync();
            }
        }

        public async Task UpdateObjectAsync(T obj)
        {
            using (var context = new ItemDbContext())
            {
                context.Set<T>().Update(obj);
                await context.SaveChangesAsync();
            }
        }

        public async Task<T> GetObjectByIdAsync(int id)
        {
            using (var context = new ItemDbContext())
            {
                return await context.Set<T>().FindAsync(id);
            }
        }
    }
}
