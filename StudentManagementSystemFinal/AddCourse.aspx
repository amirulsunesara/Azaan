<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="AddCourse.aspx.cs" Inherits="AddCourse" %>
<%@ MasterType VirtualPath="~/AdminMaster.master" %>
<asp:Content ID="Content3" ContentPlaceHolderID="Heading2" Runat="Server">
     <div class="row">
                    <div class="col-lg-12">
                        <h1 class="page-header">
                            Courses
                        </h1>
                        <ol class="breadcrumb">
                            <li>
                                <i class="fa fa-dashboard"></i>  <a href="dashboard.aspx">Dashboard</a>
                            </li>
                            <li class="active">
                                <i class="fa fa-book"></i> Courses
                            </li>
                             <li class="active">
                                </i> Add a Course
                            </li>
                        </ol>
                    </div>
                </div>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="AddCourse" Runat="Server">
      <h3>Add a Course</h3>
    <br />
    <label id="name" runat="server">Course Name:</label>  <asp:TextBox ID="txtCname" CssClass="form-control" runat="server"> </asp:TextBox>   <asp:Label ID="lblFname" runat="server" ForeColor="Red"   ></asp:Label>
        <br />
      <label  id="iname" runat="server">Instructor Name:</label> <asp:DropDownList ID="ddIname" runat="server" CssClass="form-control" AutoPostBack="True">
          <asp:ListItem Selected="True">Select Instructor</asp:ListItem>
      </asp:DropDownList> <asp:Label ID="lblLname" runat="server" ForeColor="Red"></asp:Label>
        <br />
     
        <br />
    <asp:Button ID="btnSubmit" runat="server" Text="Add Course" CssClass="btn btn-primary" OnClick="btnSubmit_Click" />
       
</asp:Content>
