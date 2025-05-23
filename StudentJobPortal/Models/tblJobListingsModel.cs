using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentJobPortal.Models
{
    public class tblJobListingsModel
    {
        public int jobListingID { get; set; }
        public int jobID { get; set; }
        public int userID { get; set; }
        public String position { get; set; }
        public String jobDescription { get; set; }
        public String jobRequirements { get; set; }
        public int jobLocationID { get; set; }
        public int minSalary { get; set; }
        public int maxSalary { get; set; }
        public DateTime dateCreated { get; set; }
        public DateTime dateUpdated { get; set; }
    }
}