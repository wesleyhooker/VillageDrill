using VillageDrill.Data;
using VillageDrill.Models.Objects;
using VillageDrill.Models.Repositories.UserClasses.Interfaces;

namespace VillageDrill.Models.Repositories.UserClasses.Classes
{
    public class ReceivedItemsRepository : RepositoryBase<ReceivedItems>, IReceivedItemsRepository
    {
        public ReceivedItemsRepository(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}