<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="Dashboard.aspx.cs" Inherits="_Default" %>
<%@ MasterType VirtualPath="~/AdminMaster.master" %>
<asp:Content ID="Content198" ContentPlaceHolderID="HD" runat="Server">
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">Dashboard
            </h1>

        </div>
    </div>
</asp:Content>

<asp:Content ID="Content182" ContentPlaceHolderID="CD" runat="Server">
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <h2 class="panel-title"><i class="fa fa-book fa-fw"></i>Current Workshops</h2>

                </div>
                <br />

             <center>     <asp:GridView ID="gvCourseRegistration" runat="server" CssClass="table  table-bordered table-responsive table-hover"   DataKeyNames="Course Id"
            AllowPaging="True" EnableViewState="False" Height="118px" Width="527px"  BorderStyle="Solid" BorderWidth="1" CellPadding="4" CellSpacing="2" ForeColor="Black"  >
              
                 <HeaderStyle BackColor="#591919" ForeColor="White" />
           
            
          </asp:GridView> </center>


                <div class="panel-body">
                </div>
            </div>
                        <div class="panel panel-default">
                <div class="panel-heading">
                    <h2 class="panel-title"><i class="fa fa-user fa-fw"></i>Registered Students</h2>

                </div>
                <br />
  <asp:PlaceHolder ID="DBDataPlaceHolder" runat="server"></asp:PlaceHolder>



                <div class="panel-body">
                </div>
            </div>
            <div class="panel panel-default">
                <div class="panel-heading">
                    <h2 class="panel-title"><i class="fa fa-bar-chart-o fa-fw"></i>Student's Feedback</h2>

                </div>
                <br />

                 <div style="text-align: center;">
        <div style="text-align: left;">
            <table class="table table-bordered table-hover " width="300px" >
        <tr style="background-color:#591919; color:white;"><td style="align-content:center;  "><h4><b> Total Feedbacks :</b> </h4> </td><td><h4><b><asp:Label ID="count" runat="server" Text=""></b></h4></asp:Label></td></tr>
        <tr><td><b>Instructor</b></td><td class="auto-style1">
            <asp:Label ID="lbli" runat="server"></asp:Label>
            </td></tr>
        <tr><td><b>venue</b></td><td class="auto-style1">
            <asp:Label ID="lblv" runat="server"></asp:Label>
            </td></tr>
        <tr><td><b>Volunteers</b></td><td class="auto-style1">
            <asp:Label ID="lblvol" runat="server"></asp:Label>
            </td></tr>
        <tr><td><b>Hospitality</b></td><td class="auto-style1">
            <asp:Label ID="lblh" runat="server"></asp:Label>
            </td></tr>
        <tr><td><b>Course</b></td><td class="auto-style1">
            <asp:Label ID="lblc" runat="server"></asp:Label>
            </td></tr>
        <tr><td><b>Registration</b></td><td class="auto-style1">
            <asp:Label ID="lblr" runat="server"></asp:Label>
            </td></tr>
        <tr><td><b>Atmosphere</b></td><td class="auto-style1">
            <asp:Label ID="lbla" runat="server"></asp:Label>
            </td></tr>
    </table>
          
        </div>
        <br />

    </div>


                <div class="panel-body">
                </div>
            </div>
        </div>
    </div>
</asp:Content>

