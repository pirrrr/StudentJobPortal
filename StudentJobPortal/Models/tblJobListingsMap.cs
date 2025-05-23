using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace StudentJobPortal.Models
{
	public class tblJobListingsMap : EntityTypeConfiguration<tblJobListingsModel>
    {
        public tblJobListingsMap()
        {
            HasKey(i => i.jobListingID);
            ToTable("tbl_joblistings");
        }
    }
}