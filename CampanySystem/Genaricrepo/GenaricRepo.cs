
using CampanySystem.Data;
using Microsoft.EntityFrameworkCore;

namespace CampanySystem.Genaricrepo
{
    public class GenaricRepo<T> : IgenaricRepo<T> where T : class
    {

        private readonly AppDbcontext appDbcontext;

        public GenaricRepo()
        {
        }

        public GenaricRepo(AppDbcontext appDbcontext)
        {
            this.appDbcontext = appDbcontext;
        }

        public async Task Add(T obj)
        {
            appDbcontext.Set<T>().AddAsync(obj);
        }

        public void Delete(int id)
        {
            var d = appDbcontext.Set<T>().Find(id);
            appDbcontext.Set<T>().Remove(d);
        }

        public  async Task<List<T>> GetAll()
        {
            return await appDbcontext.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await appDbcontext.Set<T>().FindAsync(id);
        }
    }
}
