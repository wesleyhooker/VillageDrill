using VillageDrill.Data;
using VillageDrill.Models.Objects;
using VillageDrill.Models.Repositories.UserClasses.Interfaces;

namespace VillageDrill.Models.Repositories.UserClasses.Classes
{
    public class RecipeLineRepository : RepositoryBase<RecipeLine>, IRecipeLineRepository
    {
        public RecipeLineRepository(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}