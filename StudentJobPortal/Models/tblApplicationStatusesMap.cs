using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace StudentJobPortal.Models
{
	public class tblApplicationStatusesMap : EntityTypeConfiguration<tblApplicationStatusesModel>
    {
        public tblApplicationStatusesMap()
        {
            HasKey(i => i.applicationStatusID);
            ToTable("tbl_applicationstatuses");
        }
    }
}