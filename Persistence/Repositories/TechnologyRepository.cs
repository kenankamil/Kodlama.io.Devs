using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class TechnologyRepository : EfRepositoryBase<Technology, BaseDbContext>, ITechnologyRepository
    {
        public TechnologyRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
