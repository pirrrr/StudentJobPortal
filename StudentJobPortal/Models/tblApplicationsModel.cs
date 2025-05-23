using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentJobPortal.Models
{
    public class tblApplicationsModel
    {
        public int applicationID { get; set; }
        public int userID { get; set; }
        public int jobListingsID { get; set; }
        public String coverLetter { get; set; }
        public String resume { get; set; }
        public DateTime dateApplied { get; set; }
        public int applicationStatusID { get; set; }
        public DateTime dateCreated { get; set; }
        public DateTime dateUpdated { get; set; }
    }
}