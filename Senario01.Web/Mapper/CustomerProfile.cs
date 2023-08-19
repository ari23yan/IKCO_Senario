using AutoMapper;
using Senario01.Domain.Dtos;
using Senario01.Domain.Dtos.Customer;
using Senario01.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senario01.Domain.Mapper
{
    public class CustomerProfile: Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerListDto>().ReverseMap();
        }

    }
}
