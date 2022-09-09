using Core.Persistence.Repositories;
using Domain;

namespace Application.Services.Repositories
{
    public interface ITechnologyRepository : IAsyncRepository<Technology>, IRepository<Technology>
    {
    }
}
