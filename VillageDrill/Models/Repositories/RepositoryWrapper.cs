using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VillageDrill.Data;
using VillageDrill.Models.Repositories.UserClasses.Classes;
using VillageDrill.Models.Repositories.UserClasses.Interfaces;

namespace VillageDrill.Models.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ApplicationDbContext _repoContext;
        private IApplicationUserRepository _applicationUser;
        private IAssemblyHistoryRepository _assemblyHistory;
        private IAssemblyRecipeRepository _assemblyRecipe;
        private IInventoryLogRepository _inventoryLog;
        private IItemRepository _item;
        private IMeasuresRepository _measures;
        private IOrderItemRepository _orderItem;
        private IPurchaseOrderRepository _purchaseOrder;
        private IReceivedItemsRepository _receivedItems;
        private IRecipeLineRepository _recipeLine;
        private IVendorRepository _vendor;

        public RepositoryWrapper(ApplicationDbContext repoContext)
        {
            _repoContext = repoContext;
        }

        public IApplicationUserRepository ApplicationUser
        {
            get
            {
                if (_applicationUser == null)
                {
                    _applicationUser = new ApplicationUserRepository(_repoContext);
                }

                return _applicationUser;
            }
        }

        public IAssemblyHistoryRepository AssemblyHistory
        {
            get
            {
                if (_assemblyHistory == null)
                {
                    _assemblyHistory = new AssemblyHistoryRepository(_repoContext);
                }

                return _assemblyHistory;
            }
        }

        public IAssemblyRecipeRepository AssemblyRecipe
        {
            get
            {
                if (_assemblyRecipe == null)
                {
                    _assemblyRecipe = new AssemblyRecipeRepository(_repoContext);
                }

                return _assemblyRecipe;
            }
        }

        public IInventoryLogRepository InventoryLog
        {
            get
            {
                if (_inventoryLog == null)
                {
                    _inventoryLog = new InventoryLogRepository(_repoContext);
                }

                return _inventoryLog;
            }
        }

        public IItemRepository Item
        {
            get
            {
                if (_item == null)
                {
                    _item = new ItemRepository(_repoContext);
                }

                return _item;
            }
        }

        public IMeasuresRepository Measures
        {
            get
            {
                if (_measures == null)
                {
                    _measures = new MeasuresRepository(_repoContext);
                }

                return _measures;
            }
        }

        public IOrderItemRepository OrderItem
        {
            get
            {
                if (_orderItem == null)
                {
                    _orderItem = new OrderItemRepository(_repoContext);
                }

                return _orderItem;
            }
        }

        public IPurchaseOrderRepository PurchaseOrder
        {
            get
            {
                if (_purchaseOrder == null)
                {
                    _purchaseOrder = new PurchaseOrderRepository(_repoContext);
                }

                return _purchaseOrder;
            }
        }

        public IReceivedItemsRepository ReceivedItems
        {
            get
            {
                if (_receivedItems == null)
                {
                    _receivedItems = new ReceivedItemsRepository(_repoContext);
                }

                return _receivedItems;
            }
        }

        public IRecipeLineRepository RecipeLine
        {
            get
            {
                if (_recipeLine == null)
                {
                    _recipeLine = new RecipeLineRepository(_repoContext);
                }

                return _recipeLine;
            }
        }

        public IVendorRepository Vendor
        {
            get
            {
                if (_vendor == null)
                {
                    _vendor = new VendorRepository(_repoContext);
                }

                return _vendor;
            }
        }

        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
