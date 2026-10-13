namespace CampanySystem.Genaricrepo
{
    public interface IgenaricRepo<T> where T : class
    {
         Task Add(T obj);
        void Delete(int id);
        Task<T> GetById(int id);
        Task<List<T>> GetAll();
    }
}
