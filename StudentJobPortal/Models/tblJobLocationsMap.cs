using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace StudentJobPortal.Models
{
	public class tblJobLocationsMap : EntityTypeConfiguration<tblJobLocationsModel>
    {
        public tblJobLocationsMap()
        {
            HasKey(i => i.jobLocationID);
            ToTable("tbl_joblocations");
        }
    }
}