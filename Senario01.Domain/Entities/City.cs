using Senario01.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace Senario01.Domain.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public StatusType Status { get; set; }
        [JsonIgnore]
        public ICollection<Customer> Customers { get; set; }

    }
}
