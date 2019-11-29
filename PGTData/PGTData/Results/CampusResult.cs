using PGTData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Results
{
    public class CampusResult
    {
        public int CampusID { get; set; }
        public string CampusName { get; set; }
        public int CityID { get; set; }

        public static explicit operator CampusResult(Campus obj)
        {
            CampusResult convertedObject = new CampusResult
            {
                CampusID = obj.CampusID,
                CampusName = obj.CampusName,
                CityID = obj.CityID
            };

            return convertedObject;
        }
    }
}
