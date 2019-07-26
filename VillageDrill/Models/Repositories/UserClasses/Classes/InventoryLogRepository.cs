using VillageDrill.Data;
using VillageDrill.Models.Objects;
using VillageDrill.Models.Repositories.UserClasses.Interfaces;

namespace VillageDrill.Models.Repositories.UserClasses.Classes
{
    public class InventoryLogRepository : RepositoryBase<InventoryLog>, IInventoryLogRepository
    {
        public InventoryLogRepository(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}