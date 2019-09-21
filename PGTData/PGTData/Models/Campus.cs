using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Models
{
    public class Campus
    {
        public int CampusID { get; set; }
        public string CampusName { get; set; }

        [Column("CityID")]
        public int CityID { get; set; }
        public City City { get; set; }
    }
}
