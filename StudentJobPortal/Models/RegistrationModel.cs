using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentJobPortal.Models
{
	public class RegistrationModel
	{
        public string selectedRole { get; set; }
        public int roleID { get; set; }
        public String firstName { get; set; }
        public String middleName { get; set; }
		public String lastName { get; set; }
        public String contactNumber { get; set; }
        public String emailAddress { get; set; }
        public String password { get; set; }
        public String program { get; set; }
        public String programID { get; set; }
        public String industry { get; set; }
        public String industryID { get; set; }

        public String companyName { get; set; }


    }
}