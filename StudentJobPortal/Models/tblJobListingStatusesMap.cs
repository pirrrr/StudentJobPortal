using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace StudentJobPortal.Models
{
	public class tblJobListingStatusesMap : EntityTypeConfiguration<tblJobListingStatusesModel>
    {
        public tblJobListingStatusesMap()
        {
            HasKey(i => i.jobListingStatusID);
            ToTable("tbl_joblistingstatuses");
        }
    }
}