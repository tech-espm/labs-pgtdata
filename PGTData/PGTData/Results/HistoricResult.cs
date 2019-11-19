using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Results
{
    public class HistoricResult
    {
        
        public int GroupID { get; set; }

        public string GroupName { get; set; }
        
        public int ReviewID { get; set; }

        public int Grade { get; set; }
        
        public DateTime Date { get; set; }
    }
}
