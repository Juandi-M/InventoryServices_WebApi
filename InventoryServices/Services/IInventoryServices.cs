using InventoryServices1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryServices1.Services
{
    public interface IInventoryServices
    {
        InventoryItems AddInventoryItems(InventoryItems items);

        Dictionary<string, InventoryItems> GetInventoryItems();
    }
}
