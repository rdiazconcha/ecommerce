using System.Threading.Tasks;

namespace ECommerce.Api.Search.Interfaces
{
    public interface ISearchService
    {
        Task<(bool IsSuccess, dynamic SearchResults)> SearchAsync(int customerId);
    }
}