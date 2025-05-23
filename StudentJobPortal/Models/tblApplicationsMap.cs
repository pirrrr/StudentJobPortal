using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace StudentJobPortal.Models
{
	public class tblApplicationsMap : EntityTypeConfiguration<tblApplicationsModel>
    {
        public tblApplicationsMap()
        {
            HasKey(i => i.applicationID);
            ToTable("tbl_applications");
        }
    }
}