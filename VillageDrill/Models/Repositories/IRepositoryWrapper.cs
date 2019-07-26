using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VillageDrill.Models.Repositories.UserClasses.Interfaces;

namespace VillageDrill.Models.Repositories
{
    public interface IRepositoryWrapper
    {
        IApplicationUserRepository ApplicationUser { get; }
        IAssemblyHistoryRepository AssemblyHistory { get; }
        IAssemblyRecipeRepository AssemblyRecipe { get; }
        IInventoryLogRepository InventoryLog { get; }
        IItemRepository Item { get; }
        IMeasuresRepository Measures { get; }
        IOrderItemRepository OrderItem { get; }
        IPurchaseOrderRepository PurchaseOrder { get; }
        IReceivedItemsRepository ReceivedItems { get; }
        IRecipeLineRepository RecipeLine { get; }
        IVendorRepository Vendor { get; }
        void Save();
    }
}
