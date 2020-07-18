using EplangoTask.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Protocols;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EplangoTask.CrystalReports
{
    public partial class ReportDepartmentDetails1 : System.Web.UI.Page
    {Company_Entities entities = new Company_Entities();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                // Specify the data source and field names for the Text 
                // and Value properties of the items (ListItem objects) 
                // in the DropDownList control.
                //deptId.DataSource = entities.Departments;
                //deptId.DataTextField = "DeptName";
                //deptId.DataValueField = "id";
                
                //// Bind the data to the control.
                //deptId.DataBind();

                //// Set the default selected item, if desired.
                //deptId.SelectedIndex = 0;

            }

        }
      
        public List<Department> fill()
        {
           
            return entities.Departments.ToList();
        }

        protected void deptId_SelectedIndexChanged(object sender, EventArgs e)
        {
            CrystalReportViewer1.ToolPanelView = CrystalDecisions.Web.ToolPanelViewType.None;


            var customEmp = entities.Employees.Where(x => x.DepartmentId == Convert.ToInt32(deptId.SelectedValue)).Select(x => new
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