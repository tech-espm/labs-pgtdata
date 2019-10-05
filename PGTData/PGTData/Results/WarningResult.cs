using PGTData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Results
{
    public class WarningResult
    {
        public int WarningID { get; set; }
        public string WarningDescription { get; set; }
        public DateTime WarningDate { get; set; }

        public static explicit operator WarningResult(Warning obj)
        {
            WarningResult convertedObject = new WarningResult
            {
                WarningID = obj.WarningID,
                WarningDescription = obj.WarningDescription,
                WarningDate = obj.WarningDate
            };

            return convertedObject;
        }
    }
}
