using Org.BouncyCastle.Bcpg;
using StudentJobPortal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace StudentJobPortal.Controllers
{
    public class JobPortalController : Controller
    {
        // GET: JobPortal
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoginPage()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult StudentDashboard()
        {
            return View();
        }

        public ActionResult EmployerDashboard()
        {
            return View();
        }


        public JsonResult RegisterUser(RegistrationModel regModel)
        {
            try
            {

                using (var db = new JobPortalContext())
                {
                    int roleId = regModel.selectedRole == "Student" ? 1 :
                         regModel.selectedRole == "Employer" ? 2 : 0;

                    var userData = new tblUsersModel()
                    {
                       

                        firstName = regModel.firstName,
                        middleName = regModel.middleName,
                        lastName = regModel.lastName,
                        contactNumber = regModel.contactNumber,
                        emailAddress = regModel.emailAddress,
                        password = regModel.password,
                        roleID = roleId,
                        dateCreated = DateTime.Now,
                        dateUpdated = DateTime.Now
                    };

                    db.tbl_users.AddOrUpdate(userData);
                    db.SaveChanges();

                    int userId = userData.userID;


                    if (roleId == 1) //Student
                    {

                        var program = db.tbl_programs.FirstOrDefault(i => i.program.ToLower() == regModel.program.ToLower());

                        if(program == null)
                        {
                            program = new tblProgramsModel
                            {
                                program = regModel.program
                            };
                            db.tbl_programs.AddOrUpdate(program);
                            db.SaveChanges();
                        }


                        var studentData = new tblStudentsModel()
                        {
                            userID = userId,
                            programID = program.programID
                        };
                        db.tbl_students.Add(studentData);
                    }
                    else if (roleId == 2) // Employer
                    {
                        var industry = db.tbl_industries.FirstOrDefault(i =>i.industry.ToLower() == regModel.industry.ToLower());


                        if (industry == null)
                        {
                            industry = new tblIndustriesModel
                            {
                                industry = regModel.industry
                            };
                            db.tbl_industries.AddOrUpdate(industry);
                            db.SaveChanges();
                        }

                        var employerData = new tblEmployersModel()
                        {
                            userID = userId,
                            companyName = regModel.companyName,
                            industryID = industry.industryID
                        };
                        db.tbl_employers.AddOrUpdate(employerData);
                    }
                    //else if (regModel.selectedRole == "Employer")
                    //{
                    //    var employerData = new tblEmployersModel()
                    //    {
                    //        companyName = regModel.companyName,
                    //        industryID = regModel.industry.To
                    //    }
                    //}


                    //if (regModel.selectedRole == "Student")
                    //    userData.roleID = 1;
                    //else if (regModel.selectedRole == "Employer")
                    //    userData.roleID = 2;
                    //else
                    //    return Json("Invalid Role", JsonRequestBehavior.AllowGet);

                    db.SaveChanges();


                }
                return Json("Success", JsonRequestBehavior.AllowGet);

            }catch (Exception ex)
            {
                return Json("Error: " + ex.InnerException?.Message ?? ex.Message, JsonRequestBehavior.AllowGet);
                //throw new ArgumentException(ex.Message);
            }
        }


    }
}