<%@ Page Title="" Language="C#" MasterPageFile="~/StudentMaster.master" AutoEventWireup="true" CodeFile="SCompose.aspx.cs" Inherits="_Default" %>
<%@ MasterType VirtualPath="~/StudentMaster.master" %>

<asp:Content ID="Content67" ContentPlaceHolderID="Heading50" Runat="Server">
      <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">Messages
            </h1>
            <ol class="breadcrumb">
                <li>
                    <i class="fa fa-dashboard"></i><a href="SDashboard.aspx">Dashboard</a>
                </li>
                <li class="active">
                    <i class="fa fa-inbox"></i>Messages
                </li>

            </ol>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content127" ContentPlaceHolderID="SCompose" Runat="Server">
     <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="To:"></asp:Label><br />
    <asp:DropDownList ID="ddPerson" CssClass="form-control-static" runat="server" Width="258px" AutoPostBack="True" OnSelectedIndexChanged="ddPerson_SelectedIndexChanged">
    </asp:DropDownList><asp:Label ID="lbldd" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label><br />
    <asp:DropDownList ID="ddReciever" CssClass="form-control-static" runat="server" Width="258px">
    </asp:DropDownList><br />
    <br />
   

    <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Subject:"></asp:Label><br />
    <asp:TextBox ID="txtSubject" CssClass="form-control-static" runat="server" Width="326px"></asp:TextBox><asp:Label ID="lblSubject" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label><br />
    <br />
    <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Message:"></asp:Label><br />
    <asp:TextBox ID="txtMessage" CssClass="form-control-static" runat="server" Height="200px" Width="529px" MaxLength="450" TextMode="MultiLine"></asp:TextBox><asp:Label ID="lblMessage" runat="server" ForeColor="Red" Font-Bold="True"></asp:Label><br />
    <asp:Button ID="btnSend" runat="server"  Text="Send" CssClass="btn btn-primary" OnClick="btnSend_Click1" Width="100px" />
   &nbsp&nbsp &nbsp<asp:Button ID="btnBack" runat="server" Text="Go Back" CssClass="btn btn-danger" Width="95px" OnClick="btnBack_Click" />
</asp:Content>

