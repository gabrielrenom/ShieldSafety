using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShieldSafety.Business.Repository;
using ShieldSafety.Business;
using ShieldSafety.Business.Services.Interfaces;
using ShieldSafety.DAL.Repository;
using ShieldSafety.DAL.Managers;
using ShieldSafety.Business.Services;

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
        public async void GivenAName_AddCustomer()
        {

            var result = await _customerService.AddAsync(new Business.Model.CustomerModel {
                Created = DateTime.Now,
                Modified = DateTime.Now,
                CreatedBy = "Gabi",
                ModifiedBy = "Gabi",
                DOB = DateTime.Now.AddYears(-50),
                FirstName = "Gabriel",
                Surname = "Renom",
                Telephone = "077823823"
            });


        }
    }
}
