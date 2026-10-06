namespace KodlamaNTierProject.DataAccess.Abstract.UnitOfWorks
{
    public interface IUnitOfWork:IAsyncDisposable
    {
        public IProductRepository Product {get;}
        public ICategoryRepository Category {get;}

        Task<int> SaveAsync();
    }
}