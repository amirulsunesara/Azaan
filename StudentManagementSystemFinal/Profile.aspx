<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="Profile.aspx.cs" Inherits="_Default" %>
<%@ MasterType VirtualPath="~/AdminMaster.master" %>


<asp:Content ID="PData" ContentPlaceHolderID="PD1" Runat="Server">
    <asp:Label ID="cia" runat="server" Text="Profile" Font-Bold="True" Font-Size="Large"></asp:Label>
 <asp:Label  runat="server" ID="lblSubmitted" Visible="True" Font-Size="X-Large" ForeColor="Maroon"></asp:Label><br /><br />
    <asp:Label ID="lblFnamee" runat="server" Text="First Name:" Font-Bold="True"></asp:Label> &nbsp;<asp:TextBox ID="txtFname" CssClass="form-control-static" runat="server" Width="164px"></asp:TextBox>   <asp:Label ID="lblFname" runat="server" ForeColor="Red"   ></asp:Label>
        <br />
     <asp:Label ID="lblLnamee" runat="server" Text="Last Name:" Font-Bold="True"></asp:Label>  &nbsp;<asp:TextBox ID="txtLname" CssClass="form-control-static" runat="server" Width="166px"></asp:TextBox><asp:Label ID="lblLname" runat="server" ForeColor="Red"></asp:Label>
   
 <br /><br />
    <asp:Label ID="ld" runat="server" Text="Login Details" Font-Bold="True" Font-Size="Large"></asp:Label><br /><br />
       <asp:Label ID="lblEmaill" runat="server" Text="Email:" Font-Bold="True"></asp:Label>&nbsp; <asp:TextBox ID="txtEmail" CssClass="form-control-static" runat="server" placeholder="abc@example.com" Width="159px"></asp:TextBox><asp:Label ID="lblEmail"  runat="server" ForeColor="Red"></asp:Label>
        <br />
    <asp:Label ID="lblPasswordd" runat="server" Text="Password:" Font-Bold="True"></asp:Label>   &nbsp;   <asp:TextBox ID="txtPassword" CssClass="form-control-static" runat="server" placeholder="" Width="175px" TextMode="Password"></asp:TextBox><asp:Label ID="lblPassword" runat="server" ForeColor="Red"></asp:Label>
        <br />
   <asp:Label ID="lblCPasss" runat="server" Text="Confirm Password:" Font-Bold="True"></asp:Label>  &nbsp;  <asp:TextBox ID="txtCPass" CssClass="form-control-static" runat="server" placeholder="" Width="182px" TextMode="Password"></asp:TextBox><asp:Label ID="lblCPassword" runat="server" ForeColor="Red"></asp:Label>
        <br />
      <asp:Button ID="btnUpdate" runat="server"  CssClass="btn btn-primary" Text="Edit" OnClick="btnUpdate_Click" /><asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>     <asp:Button ID="btnSubmit" runat="server"  CssClass="btn btn-primary" Text="Submit" OnClick="btnSubmit_Click" /><asp:Label ID="lblNotify" runat="server" ForeColor="Red"></asp:Label>
</asp:Content>

