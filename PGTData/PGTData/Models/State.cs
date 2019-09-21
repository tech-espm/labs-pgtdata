using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Models
{
    public class State
    {
        public int StateID { get; set; }
        public string StateName { get; set; }
        
    }
}
