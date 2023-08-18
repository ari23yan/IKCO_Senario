using Senario01.Domain.Entities;
using Senario01.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senario01.Domain.Dtos.Customer
{
    public class AddCustomerDto
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public DateTime BirthDate { get; set; }
        public int CityId { get; set; }
    }
}
