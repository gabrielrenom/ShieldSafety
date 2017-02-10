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

        public async Task<bool> DeleteAsync(int id)
        {
            return await _customerManager.DeleteByIdAsync(id);
        }

        public async Task<IEnumerable<CustomerModel>> GetAllAsync()
        {
            return await _customerManager.GetAllAsync();
        }

        public async Task<CustomerModel> GetByIdAsync(int id)
        {
            return await _customerManager.GetByIdAsync(id);
        }

        public async Task<bool> UpdateAsync(CustomerModel model)
        {
            return await _customerManager.UpdateAsync(model);
        }
    }
}
