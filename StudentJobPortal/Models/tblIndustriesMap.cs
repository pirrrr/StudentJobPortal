using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace StudentJobPortal.Models
{
	public class tblIndustriesMap : EntityTypeConfiguration<tblIndustriesModel>
    {
        public tblIndustriesMap()
        {
            HasKey(i => i.industryID);
            ToTable("tbl_industries");
        }
    }
}