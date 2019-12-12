using System.Threading.Tasks;

namespace ECommerce.Api.Search.Interfaces
{
    public interface ICustomersService
    {
        Task<(bool IsSuccess, dynamic Customer, string ErrorMessage)> GetCustomerAsync(int id);
    }
}
