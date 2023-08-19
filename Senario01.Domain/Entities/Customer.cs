using Senario01.Domain.Enums;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Senario01.Domain.Entities
{
        public class Customer
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
            public string FatherName { get; set; }
            public DateTime BirthDate { get; set; }

            public int CityId { get; set; }
            [JsonIgnore]
            public City City { get; set; }

            public StatusType Status { get; set; }
        }
}
