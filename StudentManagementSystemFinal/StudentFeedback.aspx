<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="StudentFeedback.aspx.cs" Inherits="StudentFeedback" %>
<%@ MasterType VirtualPath="~/AdminMaster.master" %>
<asp:Content ID="Content3" ContentPlaceHolderID="Heading4" Runat="Server">
     <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">Students
            </h1>
            <ol class="breadcrumb">
                <li>
                    <i class="fa fa-dashboard"></i><a href="Dashboard.aspx"> Dashboard</a>
                </li>
                <li class="active">
                    <i class="fa fa-user"></i> Students
                </li>
                <li class="active"></i> Student's Feedback
                </li>
            </ol>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="StudentFeedback" Runat="Server">
    <div style="text-align: center;">
        <div style="text-align: left;">
            <table class="table table-bordered table-hover " width="300px" >
        <tr><td style="align-content:center"><h3><b> Total Feedbacks :</b> </h3> </td><td><h3><b><asp:Label ID="count" runat="server" Text=""></b></h3></asp:Label></td></tr>
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
</asp:Content>
<asp:Content ID="Content5" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style1 {
            width: 5px;
        }
    </style>
</asp:Content>

