<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true" CodeFile="SignUpp.aspx.cs" Inherits="SignUpp" %>
<%@ MasterType VirtualPath="~/MainMaster.master" %> 


<asp:Content ID="Content1" ContentPlaceHolderID="SignUpp" Runat="Server">
    <br /><br /><br />
    <div align="center" >
  

      <br /><br />
        <br />  <br />  <br />  <br />  <br />
   
       
       <br />
         <table >
            <tr>
                <td colspan="1"> <asp:Label ID="cia" runat="server" Text="Create Account" Font-Bold="True" Font-Size="Large"></asp:Label> </td>
            <td colspan="2"> <asp:Label  runat="server" ID="lblSubmitted" Visible="True" Font-Size="X-Large" ForeColor="Maroon"></asp:Label></td>
            </tr>
          <td style="height: 13px"><td colspan="3" style="height: 13px"></td></td>
            <tr>
                <td> <asp:Label ID="lblFnamee"  runat="server" Text="First Name:" Font-Bold="True"></asp:Label></td>
                <td><asp:TextBox ID="txtFname"  CssClass="form-control-static" runat="server" Width="259px"></asp:TextBox></td>
                <td>  <asp:Label ID="lblFname" runat="server" ForeColor="Red"   ></asp:Label></td>
            </tr>
            <tr>
                <td>  <asp:Label ID="lblLnamee" runat="server" Text="Last Name:" Font-Bold="True"></asp:Label> </td>
                <td> <asp:TextBox ID="txtLname"  CssClass="form-control-static" runat="server" Width="259px"></asp:TextBox></td>
                <td> <asp:Label ID="lblLname" runat="server" ForeColor="Red"></asp:Label></td>
            </tr>
             <tr>
                <td> <asp:Label ID="lblTell" runat="server" Text="Telephone:" Font-Bold="True"></asp:Label></td>
                <td>   <asp:TextBox ID="txtTel" CssClass="form-control-static" runat="server" placeholder="02136000000" Width="258px" ></asp:TextBox></td>
                <td><asp:Label ID="lblTel" runat="server" ForeColor="Red"></asp:Label></td>
            </tr>
             <tr>
                <td> <asp:Label ID="lblCelll" runat="server" Text="Cellno:" Font-Bold="True"> </asp:Label></td>
                <td>  <asp:TextBox ID="txtCell"  CssClass="form-control-static" runat="server" placeholder="0331000000" Width="257px"></asp:TextBox></td>
                <td><asp:Label ID="lblCell" runat="server" ForeColor="Red" ></asp:Label></td>
            </tr>
             <tr>
                <td> <asp:Label ID="lblAddresss" runat="server" Text="Address:" Font-Bold="True"> </asp:Label></td>
                <td> <asp:TextBox ID="txtAddress"  CssClass="form-control-static" runat="server" Width="256px"></asp:TextBox></td>
                <td>  <asp:Label ID="lblAddress" runat="server" ForeColor="Red"  ></asp:Label></td>
            </tr>
            <tr><td colspan="3" style="height: 13px"></td></tr>
             <tr>
               
              
                <td colspan="1"> <asp:Label ID="ld" runat="server" Text="Login Details" Font-Bold="True" Font-Size="Large"></asp:Label></td>
            </tr>
            <tr><td colspan="3" style="height: 17px"></td></tr>
              <tr>
                <td>  <asp:Label ID="lblEmaill" runat="server" Text="Email:" Font-Bold="True"></asp:Label></td>
                <td><asp:TextBox ID="txtEmail"  CssClass="form-control-static" runat="server" placeholder="abc@example.com" Width="258px"></asp:TextBox></td>
                <td>   <asp:Label ID="lblEmail"  runat="server" ForeColor="Red"></asp:Label></td>
            </tr>
             <tr>
                <td> <asp:Label ID="lblPasswordd" runat="server" Text="Password:" Font-Bold="True"></asp:Label></td>
                <td>   <asp:TextBox ID="txtPassword"  CssClass="form-control-static" runat="server" placeholder="Min. 8 Characters" Width="256px"></asp:TextBox></td>
                <td> <asp:Label ID="lblPassword" runat="server" ForeColor="Red"></asp:Label></td>
            </tr>
             <tr>
                <td> <asp:Label ID="lblCPasss" runat="server" Text="Confirm Password:" Font-Bold="True"></asp:Label></td>
                <td>    <asp:TextBox ID="txtCPass"  CssClass="form-control-static" runat="server" placeholder="Min. 8 Characters" Width="259px"></asp:TextBox></td>
                <td><asp:Label ID="lblCPassword" runat="server" ForeColor="Red"></asp:Label></td>
            </tr>
               <tr><td colspan="3" style="height: 14px"></td></tr>
              <td></td>
                <td colspan="1">  <asp:Button ID="btnHome" align="right" runat="server" CssClass="btn btn-primary" Text="Back To Home" Width="123px" OnClick="btnHome_Click" />       <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" CssClass="btn btn-primary" Text="Submit" Width="133px" /></td>
                 <td><asp:Label ID="lblNotify" runat="server" ForeColor="Red"></asp:Label></td>
            </tr>
        </table>

    </div>
  
<br /><br />
</asp:Content>
