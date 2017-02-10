using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShieldSafety.Business.Repository;
using ShieldSafety.Business;
using ShieldSafety.Business.Services.Interfaces;
using ShieldSafety.DAL.Repository;
using ShieldSafety.DAL.Managers;
using ShieldSafety.Business.Services;
using System.Threading.Tasks;
using System.Linq;

namespace ShieldSafety.Test
{
    [TestClass]
    public class BusinessTest
    {

        private ISsRepository _repository;
        private ICustomerManager _customerManager;
        private ICustomerService _customerService;

        [TestInitialize]
        public void Setup()
        {
             _repository = new SsRepository();
            _customerManager = new CustomerManager(_repository);
            _customerService = new CustomerService(_customerManager);

        }

        [TestMethod]
        public async Task GivenAName_AddCustomer()
        {

            var result = await _customerService.AddAsync(new Business.Model.CustomerModel {
                Created = DateTime.Now,
                Modified = DateTime.Now,
                CreatedBy = "Gabi",
                ModifiedBy = "Gabi",
                DOB = DateTime.Now,
                FirstName = "Gabriel",
                Surname = "Renom",
                Telephone = "077823823"
            });

            Assert.AreEqual(result.FirstName, "Gabriel");
        }

        [TestMethod]
        public async Task GivenAnId_RemoveCustomer()
        {

            var addedCustomer = await _customerService.AddAsync(new Business.Model.CustomerModel
            {
                Created = DateTime.Now,
                Modified = DateTime.Now,
                CreatedBy = "Gabi",
                ModifiedBy = "Gabi",
                DOB = DateTime.Now,
                FirstName = "Gabriel",
                Surname = "Renom",
                Telephone = "077823823"
            });

            var result = await _customerService.DeleteAsync(addedCustomer.Id);

            Assert.IsTrue(result);
        }
        [TestMethod]
        public async Task GivenAnId_UpdateCustomer()
        {

            var addedCustomer = await _customerService.AddAsync(new Business.Model.CustomerModel
            {
                Created = DateTime.Now,
                Modified = DateTime.Now,
                CreatedBy = "Gabi",
                ModifiedBy = "Gabi",
                DOB = DateTime.Now,
                FirstName = "Gabriel",
                Surname = "Renom",
                Telephone = "077823823"
            });

            addedCustomer.Surname = "Trump";

            var result = await _customerService.UpdateAsync(addedCustomer);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public async Task GetAllCustomers()
        {
            var result = await _customerService.GetAllAsync();
     
            Assert.IsTrue(result.Count()>0);
        }

        [TestMethod]
        public async Task GetCustomersById()
        {
            var customers = await _customerService.GetAllAsync();

            var result = await _customerService.GetByIdAsync(customers.FirstOrDefault().Id);

            Assert.AreEqual(result.Id, customers.FirstOrDefault().Id);
        }
    }
}
