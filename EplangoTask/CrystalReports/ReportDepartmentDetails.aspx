<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportDepartmentDetails.aspx.cs" Inherits="EplangoTask.CrystalReports.ReportDepartmentDetails1" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container row">
            <div>
                <asp:DropDownList ID="deptId" runat="server" SelectMethod="fill" OnSelectedIndexChanged="deptId_SelectedIndexChanged">

                </asp:DropDownList>
            </div>
        </div>
        <div>
            <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" />
        </div>
    </form>
</body>
</html>
