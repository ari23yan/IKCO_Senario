using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Senario01.Domain.Enums.Common
{

    public enum RequestResponse
    {
        [Display(Name = "Success")]
        Success,
        [Display(Name = "Faild")]
        Faild,
        [Display(Name = "NullInputs")]
        NullInputs,
        [Display(Name = "NullResult")]
        NullResult,

    }
}
