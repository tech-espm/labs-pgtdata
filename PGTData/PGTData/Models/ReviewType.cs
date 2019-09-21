using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Models
{
    public class ReviewType
    {
        public int ReviewTypeID { get; set; }
        public string ReviewTypeDescription { get; set; }
        
    }
}
