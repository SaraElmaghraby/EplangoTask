using CrystalDecisions.Web;
using EplangoTask.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EplangoTask.CrystalReports
{
    public partial class ReportEmployee1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



            CrystalReportViewer1.ToolPanelView = CrystalDecisions.Web.ToolPanelViewType.None;
           
            Company_Entities entities = new Company_Entities();
          
            var customEmp = entities.Employees.Select(x => new
            {
                id = x.Id,
                Name = x.Name,
                Address = x.Address,
                Phone = x.Phone,
                Department = x.Department.DeptName
            }).ToList();
            ReportEmployee rpt = new ReportEmployee();
           
            rpt.SetDataSource(customEmp);
            CrystalReportViewer1.ReportSource = rpt;
        }
       
    }
}