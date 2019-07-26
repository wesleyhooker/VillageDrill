using VillageDrill.Data;
using VillageDrill.Models.Objects;
using VillageDrill.Models.Repositories.UserClasses.Interfaces;

namespace VillageDrill.Models.Repositories.UserClasses.Classes
{
    public class ItemRepository : RepositoryBase<Item>, IItemRepository
    {
        public ItemRepository(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}