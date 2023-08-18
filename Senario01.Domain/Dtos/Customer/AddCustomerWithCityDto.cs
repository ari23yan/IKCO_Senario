using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senario01.Domain.Dtos.Customer
{
    public class AddCustomerWithCityDto
    {
        public AddCustomerDto Customer { get; set; }
        public int SelectedCityId { get; set; }

    }
}
