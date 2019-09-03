using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Models
{
    public class Professor_PGT
    {
        public int Professor_PGTID { get; set; }

        public User User { get; set; }
    }
}
