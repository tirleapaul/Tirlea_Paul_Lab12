using System.Collections.Generic;
using System.Threading.Tasks;
using Tirlea_Paul_Lab12.Models;

namespace Tirlea_Paul_Lab12.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
