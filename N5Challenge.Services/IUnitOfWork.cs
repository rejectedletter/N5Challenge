using N5Company.WebApi.Data;

namespace N5Challenge.WebApi.Services
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> Save();

        void Dispose();
    }
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
                _context = context;
        }

        public Task<int> Save()
        {
            return _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
