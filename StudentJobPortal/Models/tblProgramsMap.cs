using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace StudentJobPortal.Models
{
	public class tblProgramsMap : EntityTypeConfiguration<tblProgramsModel>
    {
        public tblProgramsMap()
        {
            HasKey(i => i.programID);
            ToTable("tbl_programs");
        }
    }
}