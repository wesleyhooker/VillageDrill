using VillageDrill.Data;
using VillageDrill.Models.Objects;
using VillageDrill.Models.Repositories.UserClasses.Interfaces;

namespace VillageDrill.Models.Repositories.UserClasses.Classes
{
    public class MeasuresRepository : RepositoryBase<Measures>, IMeasuresRepository
    {
        public MeasuresRepository(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}