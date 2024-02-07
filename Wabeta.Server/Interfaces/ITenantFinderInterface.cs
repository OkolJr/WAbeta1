using WAbeta.Server.Data;

namespace WAbeta.Server.Interfaces
{
    public interface ITenantFinderInterface
    {
        Task<Guid> GetTenantId(string userEmail, ApplicationDbContext dbContext);
    }
}
