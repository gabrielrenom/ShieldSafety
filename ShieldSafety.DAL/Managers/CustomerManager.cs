using ShieldSafety.Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShieldSafety.Business.Repository;
using System.Linq.Expressions;
using ShieldSafety.Business.Managers;
using ShieldSafety.Data.Models;
using ShieldSafety.Business;

namespace ShieldSafety.DAL.Managers
{
    public class CustomerManager : BaseManager<CustomerModel, Customer>, ICustomerManager
    {
        public CustomerManager(ISsRepository repository)
            : base(repository)
        {
            Repository = repository;
        }
        
        public override async Task<CustomerModel> AddAsync(CustomerModel domainModel)
        {
            return await base.AddAsync(domainModel);
        }

        public override Customer ToDataModel(CustomerModel domainModel, Customer dataModel = null)
        {
            return new Customer
            {
                Created = domainModel.Created,
                CreatedBy = domainModel.CreatedBy,
                DOB = domainModel.DOB,
                FirstName = domainModel.FirstName,
                Modified = domainModel.Modified,
                ModifiedBy = domainModel.ModifiedBy,
                Surname = domainModel.Surname,
                Telephone = domainModel.Telephone
            };
        }

        public override Customer ToDataModelWithChildNodes(CustomerModel domainModel, Customer dataModel = null)
        {
            return new Customer
            {
                 Created = domainModel.Created,
                  CreatedBy = domainModel.CreatedBy,
                   DOB = domainModel.DOB,
                    FirstName = domainModel.FirstName,
                      Modified = domainModel.Modified,
                       ModifiedBy = domainModel.ModifiedBy,
                        Surname = domainModel.Surname,
                         Telephone = domainModel.Telephone
            };
        }

        public override CustomerModel ToDomainModel(Customer dataModel)
        {
            return new CustomerModel
            {
                 Created = dataModel.Created,
                  CreatedBy = dataModel.CreatedBy,
                   DOB = dataModel.DOB,
                    FirstName = dataModel.FirstName,
                     Id= dataModel.Id,
                      Modified = dataModel.Modified,
                       ModifiedBy = dataModel.ModifiedBy,
                        Surname = dataModel.Surname,
                          Telephone = dataModel.Telephone
            };
        }

        public override CustomerModel ToDomainModelWithChildNodes(Customer dataModel)
        {
            return new CustomerModel
            {
                Created = dataModel.Created,
                CreatedBy = dataModel.CreatedBy,
                DOB = dataModel.DOB,
                FirstName = dataModel.FirstName,
                Id = dataModel.Id,
                Modified = dataModel.Modified,
                ModifiedBy = dataModel.ModifiedBy,
                Surname = dataModel.Surname,
                Telephone = dataModel.Telephone
            };
        }

        public override async Task<bool> UpdateAsync(CustomerModel domainModel)
        {
            var customer = await Repository.GetSingleAsync<Customer>(x => x.Id == domainModel.Id);

            if (customer != null)
            {
                customer.FirstName = domainModel.FirstName;
                customer.Surname = domainModel.Surname;
                customer.Telephone = domainModel.Telephone;
                customer.DOB = domainModel.DOB;
        
            }

            Repository.Update<Customer>(customer);
            var result = Repository.CommitAsync();

            return true;

        }
    }
}
