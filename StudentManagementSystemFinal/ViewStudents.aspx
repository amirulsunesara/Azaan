<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="ViewStudents.aspx.cs" Inherits="ViewStudents" %>
<%@ MasterType VirtualPath="~/AdminMaster.master" %>
<asp:Content ID="Content7" ContentPlaceHolderID="Heading5" runat="Server">
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">Students
            </h1>
            <ol class="breadcrumb">
                <li>
                    <i class="fa fa-dashboard"></i><a href="Dashboard.aspx">Dashboard</a>
                </li>
                <li class="active">
                    <i class="fa fa-user"></i> Students
                </li>
                <li class="active"></i> Student's Record
                </li>
            </ol>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content8" ContentPlaceHolderID="ViewStudents" runat="Server">
    <div style="text-align: center;">
        <div style="text-align: left;">
            &nbsp;<asp:TextBox runat="server" CssClass="form-control-static" ID="txtSearch" placeholder="Search by Student Name"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" CssClass="btn btn-primary" Text="Search" OnClick="btnSearch_Click1" />
        </div>
        <br />
        <asp:GridView ID="gvStudents" runat="server" CssClass="table table-bordered table-hover table-responsive" Width="681px">
            
        </asp:GridView>
           <label id="lblEmpty" runat="server" >No Students Found <a href="ViewStudents.aspx"> View All Students </a></label>
    </div>
</asp:Content>

