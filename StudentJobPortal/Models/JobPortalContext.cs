using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentJobPortal.Models
{
	[DbConfigurationType(typeof(MySqlEFConfiguration))]
	public class JobPortalContext : DbContext
	{
		static JobPortalContext()
		{
			Database.SetInitializer<JobPortalContext>(null);
		}
		public JobPortalContext() : base("name=jobportaldb") { }

		public virtual DbSet<tblUsersModel> tbl_users { get; set; }
        public virtual DbSet<tblStudentsModel> tbl_students { get; set; }
        public virtual DbSet<tblRolesModel> tbl_roles { get; set; }
        public virtual DbSet<tblProgramsModel> tbl_programs { get; set; }
        public virtual DbSet<tblJobsModel> tbl_jobs { get; set; }
        public virtual DbSet<tblJobLocationsModel> tbl_joblocations { get; set; }
        public virtual DbSet<tblJobListingStatusesModel> tbl_joblistingstatuses { get; set; }
        public virtual DbSet<tblJobListingsModel> tbl_joblistings { get; set; }
        public virtual DbSet<tblIndustriesModel> tbl_industries { get; set; }
        public virtual DbSet<tblEmployersModel> tbl_employers { get; set; }
        public virtual DbSet<tblApplicationStatusesModel> tbl_applicationstatuses { get; set; }
        public virtual DbSet<tblApplicationsModel> tbl_applications { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new tblUsersMap());
            modelBuilder.Configurations.Add(new tblStudentsMap());
            modelBuilder.Configurations.Add(new tblRolesMap());
            modelBuilder.Configurations.Add(new tblProgramsMap());
            modelBuilder.Configurations.Add(new tblJobsMap());
            modelBuilder.Configurations.Add(new tblJobLocationsMap());
            modelBuilder.Configurations.Add(new tblJobListingStatusesMap());
            modelBuilder.Configurations.Add(new tblJobListingsMap());
            modelBuilder.Configurations.Add(new tblIndustriesMap());
            modelBuilder.Configurations.Add(new tblEmployersMap());
            modelBuilder.Configurations.Add(new tblApplicationStatusesMap());
            modelBuilder.Configurations.Add(new tblApplicationsMap());
        }


    }
}