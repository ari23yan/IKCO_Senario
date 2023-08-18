using Senario01.Domain.Entities;
using Senario01.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senario01.Domain.Dtos.City
{
    public class CityListDto
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public StatusType Status { get; set; }
    }
}
