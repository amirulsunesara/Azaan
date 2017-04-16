<%@ Page Title="" Language="C#" MasterPageFile="~/InstructorMaster.master" AutoEventWireup="true" CodeFile="IViewStudents.aspx.cs" Inherits="_Default" %>
<%@ MasterType VirtualPath="~/InstructorMaster.master" %>
<asp:Content ID="Content7" ContentPlaceHolderID="Heading10" runat="Server">
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">Students
            </h1>
            <ol class="breadcrumb">
                <li>
                    <i class="fa fa-dashboard"></i><a href="IDashboard.aspx">Dashboard</a>
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

<asp:Content ID="Content8" ContentPlaceHolderID="IViewStudents" runat="Server">
    <div >
              <div style="text-align: left;">
       
       
         
        </div>
        <br />
     <asp:GridView   CssClass="table table-bordered table-hover table-responsive" ID="gvStudents" runat="server" Width="681px">
           <HeaderStyle  HorizontalAlign="Center" VerticalAlign="Middle" CssClass="headerClass" BackColor="Black" Font-Bold="True" ForeColor="White" />
     </asp:GridView>
        <label id="lblEmpty" runat="server" >No Students Found <a href="IViewStudents.aspx"> View All Students </a></label>

    </div>
</asp:Content>
