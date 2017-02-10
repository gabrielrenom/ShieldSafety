using ShieldSafety.Business.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShieldSafety.Business.Model;

namespace ShieldSafety.Business.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerManager _customerManager;

        public CustomerService (ICustomerManager customerManager)
        {
            _customerManager = customerManager;
        }

        public async Task<CustomerModel> AddAsync(CustomerModel model)
        {
            return await _customerManager.AddAsync(model);
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CustomerModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(CustomerModel model)
        {
            throw new NotImplementedException();
        }
    }
}
