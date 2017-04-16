<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="InstructorSignUp.aspx.cs" Inherits="InstructorSignUp" %>
<%@ MasterType VirtualPath="~/AdminMaster.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Heading1" Runat="Server">
    <div class="row">
                    <div class="col-lg-12">
                        <h1 class="page-header">
                            Instructors
                        </h1>
                        <ol class="breadcrumb">
                            <li>
                                <i class="fa fa-dashboard"></i>  <a href="Dashboard.aspx">Dashboard</a>
                            </li>
                            <li class="active">
                                <i class="fa fa-male"></i> Instructors
                            </li>
                             <li class="active">
                                </i> Create Instructor's Account
                            </li>
                        </ol>
                    </div>
                </div>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="InstructorForm" Runat="Server">
  
    <asp:Label ID="cia" runat="server" Text="Create Instructor's Account" Font-Bold="True" Font-Size="Large"></asp:Label>
 <asp:Label  runat="server" ID="lblSubmitted" Visible="True" Font-Size="X-Large" ForeColor="Maroon"></asp:Label><br /><br />
    <asp:Label ID="lblFnamee" runat="server" Text="First Name:" Font-Bold="True"></asp:Label> <asp:TextBox ID="txtFname" CssClass="form-control" runat="server"> </asp:TextBox>   <asp:Label ID="lblFname" runat="server" ForeColor="Red"   ></asp:Label>
        <br />
     <asp:Label ID="lblLnamee" runat="server" Text="Last Name:" Font-Bold="True"></asp:Label>  <asp:TextBox ID="txtLname" CssClass="form-control" runat="server"></asp:TextBox><asp:Label ID="lblLname" runat="server" ForeColor="Red"></asp:Label>
        <br />
   <asp:Label ID="lblTell" runat="server" Text="Telephone:" Font-Bold="True"></asp:Label> <asp:TextBox ID="txtTel" CssClass="form-control" runat="server" placeholder="02136000000" ></asp:TextBox><asp:Label ID="lblTel" runat="server" ForeColor="Red"></asp:Label>
        <br />
   <asp:Label ID="lblCelll" runat="server" Text="Cellno:" Font-Bold="True"> </asp:Label> <asp:TextBox ID="txtCell" CssClass="form-control" runat="server" placeholder="0331000000"></asp:TextBox><asp:Label ID="lblCell" runat="server" ForeColor="Red" ></asp:Label>
        <br />
   <asp:Label ID="lblAddresss" runat="server" Text="Address:" Font-Bold="True"> </asp:Label>   <asp:TextBox ID="txtAddress" CssClass="form-control" runat="server"></asp:TextBox><asp:Label ID="lblAddress" runat="server" ForeColor="Red"  ></asp:Label>
        <br />
       
 
    <asp:Label ID="ld" runat="server" Text="Login Details" Font-Bold="True" Font-Size="Large"></asp:Label><br /><br />
       <asp:Label ID="lblEmaill" runat="server" Text="Email:" Font-Bold="True"></asp:Label><asp:TextBox ID="txtEmail" CssClass="form-control" runat="server" placeholder="abc@example.com"></asp:TextBox><asp:Label ID="lblEmail"  runat="server" ForeColor="Red"></asp:Label>
        <br />
    <asp:Label ID="lblPasswordd" runat="server" Text="Password:" Font-Bold="True"></asp:Label>   <asp:TextBox ID="txtPassword" CssClass="form-control" runat="server" placeholder="Min. 8 Characters" TextMode="Password"></asp:TextBox><asp:Label ID="lblPassword" runat="server" ForeColor="Red"></asp:Label>
        <br />
   <asp:Label ID="lblCPasss" runat="server" Text="Confirm Password:" Font-Bold="True"></asp:Label>  <asp:TextBox ID="txtCPass" CssClass="form-control" runat="server" placeholder="Min. 8 Characters" TextMode="Password"></asp:TextBox><asp:Label ID="lblCPassword" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" CssClass="btn btn-primary" Text="Submit" /><asp:Label ID="lblNotify" runat="server" ForeColor="Red"></asp:Label>
</asp:Content>

