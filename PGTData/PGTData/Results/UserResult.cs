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
        public string UserName { get; set; }
        public int UserRegister { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public int CampusID { get; set; }
        public int UserTypeID { get; set; }
        public int GroupID { get; set; }

        public List<Warning> Warnings { get; set; }

        public List<Review> Reviews { get; set; }

        public static explicit operator UserResult(User obj)
        {
            UserResult convertedObject = new UserResult
            {
                UserID = obj.UserID,
                UserName = obj.UserName,
                UserRegister = obj.UserRegister,
                UserEmail = obj.UserEmail,
                UserPassword = obj.UserPassword,
                CampusID = obj.CampusID,
                UserTypeID = obj.UserTypeID,
                GroupID = obj.GroupID
            };

            if (obj.Warnings != null)
            {
                convertedObject.Warnings = obj.Warnings;
            }
            if (obj.Reviews != null)
            {
                convertedObject.Reviews = obj.Reviews;
            }

            return convertedObject;
        }
    }
}
