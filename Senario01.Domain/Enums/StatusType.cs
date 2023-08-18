using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Senario01.Domain.Enums
{
    public enum StatusType
    {
        [Display(Name = "Active")]
        Inactive,

        [Display(Name = "Inactive")]
        Active,

    }
}
