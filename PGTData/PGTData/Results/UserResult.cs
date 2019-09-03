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

        public List<Professor_PGT> Professor_PGT { get; set; }

        public static explicit operator UserResult(User obj)
        {
            UserResult convertedObject = new UserResult
            {
                UserID = obj.UserID,
                Professor_PGT = obj.Professor_PGT
            };

            return convertedObject;
        }
    }
}
