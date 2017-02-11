using ShieldSafety.Business.Model;
using ShieldSafety.Business.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ShieldSafety.Web.Controllers
{
    public class CustomerController : Controller
    {

        private ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET: Customer
        public async Task <ActionResult> Index()
        {
            var result = await _customerService.GetAllAsync();

            return View(result);
        }

        // GET: Customer/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var result = await _customerService.GetByIdAsync(id);

            return View(result);
        }

        // GET: Customer/Create
        public async Task<ActionResult> Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public async Task<ActionResult> Create(CustomerModel customer)
        {
            try
            {
                var result = await _customerService.AddAsync(customer);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var result = await _customerService.GetByIdAsync(id);

            return View(result);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(CustomerModel customer)
        {
            try
            {
                var result = await _customerService.UpdateAsync(customer);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _customerService.GetByIdAsync(id);

            return View(result);
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public async Task<ActionResult> Delete( CustomerModel customer)
        {
            try
            {
                var result = await _customerService.DeleteAsync(customer.Id);

                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return View();
            }
            
        }
    }
}
