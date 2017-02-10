using ShieldSafety.Business.Managers;
using ShieldSafety.Business.Model;

using ShieldSafety.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShieldSafety.Business
{
    public interface ICustomerManager:  IBaseManager<CustomerModel, Customer>
    {
    }
}
