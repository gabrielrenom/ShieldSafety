using ShieldSafety.Business.Model;
using ShieldSafety.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShieldSafety.Business.Repository;
using System.Linq.Expressions;

namespace ShieldSafety.DAL.Managers
{
    public class CustomerManager : IBaseManager<CustomerModel, Customer>
    {
        public IGenericRepository Repository
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Task<CustomerModel> AddAsync(CustomerModel domainModel)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CustomerModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CustomerModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CustomerModel>> GetListAsync(Expression<Func<Customer, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerModel> GetSingleAsync(Expression<Func<Customer, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Customer ToDataModel(CustomerModel domainModel, Customer dataModel = null)
        {
            throw new NotImplementedException();
        }

        public Customer ToDataModelWithChildNodes(CustomerModel domainModel, Customer dataModel = null)
        {
            throw new NotImplementedException();
        }

        public CustomerModel ToDomainModel(Customer dataModel)
        {
            throw new NotImplementedException();
        }

        public CustomerModel ToDomainModelWithChildNodes(Customer dataModel)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(CustomerModel domainModel)
        {
            throw new NotImplementedException();
        }
    }
}
