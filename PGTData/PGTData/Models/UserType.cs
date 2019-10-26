using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Models
{
    public class UserType
    {
        public int UserTypeID { get; set; }

        public string UserTypeDescription { get; set; }
    }
}
