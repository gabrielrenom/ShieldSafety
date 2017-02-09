using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShieldSafety.Business.Model
{
    public class CustomerModel: BaseModel
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Telephone { get; set; }
        public DateTime DOB { get; set; }
    }
}
