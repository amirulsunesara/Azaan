<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="Enrollment.aspx.cs" Inherits="Enrollment" %>
<%@ MasterType VirtualPath="~/AdminMaster.master" %>
<asp:Content ID="Content5" ContentPlaceHolderID="Heading3" Runat="Server">
     <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">Courses
            </h1>
            <ol class="breadcrumb">
                <li>
                    <i class="fa fa-dashboard"></i><a href="dashboard.aspx"> Dashboard</a>
                </li>
                <li class="active">
                    <i class="fa fa-book"></i> Courses
                </li>
                <li class="active"></i> Student Enrollment
                </li>
            </ol>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content6" ContentPlaceHolderID="Enrollment" Runat="Server">
     <div style="text-align: center;">
       
       <asp:Label ID="lblNo" runat="server" Text="There are no Enrollment for Courses" Font-Bold="True" Font-Size="X-Large" ForeColor="Maroon"></asp:Label>
         <asp:PlaceHolder ID="DBDataPlaceHolder" runat="server"></asp:PlaceHolder>

    </div>
</asp:Content>
