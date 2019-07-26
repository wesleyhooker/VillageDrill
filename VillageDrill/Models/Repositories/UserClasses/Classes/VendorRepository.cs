using VillageDrill.Data;
using VillageDrill.Models.Objects;
using VillageDrill.Models.Repositories.UserClasses.Interfaces;

namespace VillageDrill.Models.Repositories.UserClasses.Classes
{
    public class VendorRepository : RepositoryBase<Vendor>, IVendorRepository
    {
        public VendorRepository(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}