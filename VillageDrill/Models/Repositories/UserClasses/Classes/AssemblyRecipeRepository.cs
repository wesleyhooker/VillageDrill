using VillageDrill.Data;
using VillageDrill.Models.Objects;
using VillageDrill.Models.Repositories.UserClasses.Interfaces;

namespace VillageDrill.Models.Repositories.UserClasses.Classes
{
    public class AssemblyRecipeRepository : RepositoryBase<AssemblyRecipe>, IAssemblyRecipeRepository
    {
        public AssemblyRecipeRepository(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}