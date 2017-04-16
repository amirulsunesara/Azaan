<%@ Page Title="" Language="C#" MasterPageFile="~/InstructorMaster.master" AutoEventWireup="true" CodeFile="UploadMarks.aspx.cs" Inherits="UploadMarks" %>
<%@ MasterType VirtualPath="~/InstructorMaster.master" %>
<%-- Add content controls here --%>
<asp:Content ID="Content903" ContentPlaceHolderID="Heading2" Runat="Server">
     <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">Courses
            </h1>
            <ol class="breadcrumb">
                <li>
                    <i class="fa fa-dashboard"></i><a href="IDashboard.aspx"> Dashboard</a>
                </li>
                <li class="active">
                    <i class="fa fa-book"></i> Courses
                </li>
                <li class="active"> Upload Marks
                </li>
            </ol>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content904" ContentPlaceHolderID="UploadMarks" Runat="Server">
     <div style="text-align: center;">
       
      
                    <asp:PlaceHolder ID="DBDataPlaceHolder" runat="server"></asp:PlaceHolder>  
          
             </div>
    <br />
         <asp:Button ID="btnSubmit" CssClass="btn-primary" runat="server" Text="Submit" OnClick="btnSubmit_Click" />

         <asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="Red" Font-Size="Large"></asp:Label>


</asp:Content>