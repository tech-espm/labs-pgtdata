using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Models
{
    public class City
    {
        public int CityID { get; set; }
        public string CityName { get; set; }

        [Column("StateID")]
        public int StateID { get; set; }
        public State State { get; set; }
        
    }
}
