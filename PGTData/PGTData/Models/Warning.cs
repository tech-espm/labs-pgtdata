using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Models
{
    public class Warning
    {
        public int WarningID { get; set; }
        public string WarningDescription { get; set; }
        public DateTime WarningDate { get; set; }
        
    }
}
