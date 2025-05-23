using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace StudentJobPortal.Models
{
	public class tblStudentsMap : EntityTypeConfiguration<tblStudentsModel>
    {
        public tblStudentsMap()
        {
            HasKey(i => i.userID);
            ToTable("tbl_students");
        }
    }
}