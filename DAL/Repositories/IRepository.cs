namespace CookBookRecipe.DAL.Repositories
{
    public interface IRepository<T>
    {
        T Get(int id);
        T GetAll();
        void Add(T obj);
        //void Update(T obj);

        void Delete(T obj);
    }
}
