using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentJobPortal.Models
{
    public class tblUsersModel
    {
        public int userID { get; set; }
        public int roleID { get; set; }
        public String firstName { get; set; }
        public String middleName { get; set; }
        public String lastName { get; set; }
        public String contactNumber { get; set; }
        public String emailAddress { get; set; }
        public String password { get; set; }
        public DateTime dateCreated { get; set; }
        public DateTime dateUpdated { get; set; }
    }
}