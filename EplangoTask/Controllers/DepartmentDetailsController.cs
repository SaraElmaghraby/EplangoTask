using CrystalDecisions.CrystalReports.Engine;
using EplangoTask.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace EplangoTask.Controllers
{         

    public class DepartmentDetailsController : Controller
    {  
        

        private Company_Entities db = new Company_Entities();
        // GET: DepartmentDetails
        public ActionResult DepartmentDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Department DepartmentDetails = db.Departments.Find(id);
            if (DepartmentDetails == null)
            {
                return HttpNotFound();
            }
            List<Employee> EmpoyeeDetails = db.Employees.Where(x => x.DepartmentId == id).ToList();
            TempData["custom"] = id;
           

            return View(EmpoyeeDetails);
        }
        public ActionResult ExportDepartmentDetails()
        {
            int id = Convert.ToInt32(TempData["custom"]);

            var customEmp = db.Employees.Where(x => x.DepartmentId == id).Select(x => new
            {
                id = x.Id,
                Name = x.Name,
                Address = x.Address,
                Phone = x.Phone,
                Department = x.Department.DeptName
            }).ToList();
            TempData["custom"] = customEmp;
            ReportDocument rd = new ReportDocument();
            rd.Load(Path.Combine(Server.MapPath("~/CrystalReports"), "ReportDepartmentDetails.rpt"));

            rd.SetDataSource(customEmp);

            Response.Buffer = false;
            Response.ClearContent();
            Response.ClearHeaders();


            Stream stream = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
            stream.Seek(0, SeekOrigin.Begin);
            return File(stream, "application/pdf", "DepartmentDetailsList.pdf");
        }
    }
}