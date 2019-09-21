using PGTData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Results
{
    public class UserResult
    {
        public int UserID { get; set; }

        public static explicit operator UserResult(User obj)
        {
            UserResult convertedObject = new UserResult
            {
                UserID = obj.UserID
            };

            return convertedObject;
        }
    }
}
