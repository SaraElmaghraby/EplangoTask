using CrystalDecisions.Web;
using EplangoTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EplangoTask.CrystalReports
{
    public partial class ReportDepartment1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CrystalReportViewer1.ToolPanelView = CrystalDecisions.Web.ToolPanelViewType.None;
            ReportDepartment crystalReport = new ReportDepartment();
            Company_Entities entities = new Company_Entities();
            List<Department> allDepartment = new List<Department>();
            allDepartment = entities.Departments.ToList();
            //crystalReport.SetDataSource(allDepartment);
            //CrystalReportViewer1.ReportSource = crystalReport;
            //CrystalReportViewer1.RefreshReport();
            ReportDepartment rpt = new ReportDepartment();
            rpt.SetDataSource(allDepartment);
            CrystalReportViewer1.ReportSource = rpt;
                //ViewerCore
                
        }
    }
}