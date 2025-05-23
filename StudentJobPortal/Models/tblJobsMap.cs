using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace StudentJobPortal.Models
{
	public class tblJobsMap : EntityTypeConfiguration<tblJobsModel>
    {
        public tblJobsMap()
        {
            HasKey(i => i.jobID);
            ToTable("tbl_jobs");
        }
    }
}