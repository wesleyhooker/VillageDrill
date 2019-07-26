using VillageDrill.Data;
using VillageDrill.Models.Objects;
using VillageDrill.Models.Repositories.UserClasses.Interfaces;

namespace VillageDrill.Models.Repositories.UserClasses.Classes
{
    public class AssemblyHistoryRepository : RepositoryBase<AssemblyHistory>, IAssemblyHistoryRepository
    {
        public AssemblyHistoryRepository(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}