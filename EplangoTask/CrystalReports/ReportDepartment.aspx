<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportDepartment.aspx.cs" Inherits="EplangoTask.CrystalReports.ReportDepartment1" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <script lang="javaScript" type="text/javascript" src="../Content/crystalreportviewers13/js/crviewer/crv.js"></script> 

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <cr:crystalreportviewer runat="server" ID="CrystalReportViewer1" autodatabind="true" ></cr:crystalreportviewer>
        </div>
    </form>
</body>
</html>
