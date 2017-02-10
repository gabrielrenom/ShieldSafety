using ShieldSafety.Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShieldSafety.Business.Services.Interfaces
{
    public interface ICustomerService
    {
        Task<CustomerModel> AddAsync(CustomerModel model);
        Task<bool> UpdateAsync(CustomerModel model);
        Task<IEnumerable<CustomerModel>> GetAllAsync();
        Task<bool> DeleteAsync(int id);
    }
}
