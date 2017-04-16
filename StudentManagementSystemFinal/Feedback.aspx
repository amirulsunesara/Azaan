<%@ Page Title="" Language="C#" MasterPageFile="~/StudentMaster.master" AutoEventWireup="true" CodeFile="Feedback.aspx.cs" Inherits="Feedback" %>
<%@ MasterType VirtualPath="~/StudentMaster.master" %>
<asp:Content ID="Content5" ContentPlaceHolderID="Heading3" Runat="Server">
     <div class="row">
                    <div class="col-lg-12">
                        <h1 class="page-header">
                            Courses
                        </h1>
                        <ol class="breadcrumb">
                            <li>
                                <i class="fa fa-dashboard"></i>  <a href="SDashboard.aspx">Dashboard</a>
                            </li>
                            <li class="active">
                                <i class="fa fa-pencil"></i> Feedback
                            </li>
                            
                        </ol>
                    </div>
                </div>
</asp:Content>

<asp:Content ID="Content6" ContentPlaceHolderID="SendFeedback" Runat="Server">
               <div class="row">
                    <div class="col-lg-12">
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <h2 class="panel-title"><i class="fa fa-bar-chart-o fa-fw"></i>Grade our workshop</h2>
                            </div>
                            <br />
                         &nbsp&nbsp <asp:Label ID="lblSubmitted" runat="server" Font-Size="X-Large" Font-Bold="True" ForeColor="#000066"></asp:Label>
    <asp:Panel ID="pnlFeedback" runat="server">
    
    <table style="padding:2px; height: 379px; width: 757px; text-align:center; border:ridge" class="table-hover" border="1" >
        <tr><td style="background-color:#151C47; color:white" >Instructor</td><td>
            <asp:RadioButton ID="II1" Text="Very Poor" GroupName="instructor" runat="server" />
            </td><td>
                <asp:RadioButton ID="II2" Text="Poor" GroupName="instructor" runat="server" />
            </td><td>
                <asp:RadioButton ID="II3" Text="Satisfactory" GroupName="instructor" runat="server" />
            </td><td style="width: 94px">
                <asp:RadioButton ID="II4" Text="Good" GroupName="instructor" runat="server" />
            </td><td style="width: 155px">
                <asp:RadioButton ID="II5" Text="Excellent" GroupName="instructor" runat="server" />
            </td></tr>
         <tr><td style="background-color:#151C47; color:white">Venue</td><td>
             <asp:RadioButton ID="V1" Text="Very Poor" GroupName="venue" runat="server" />
             </td><td>
                 <asp:RadioButton ID="V2" Text="Poor"  GroupName="venue" runat="server" />
             </td><td>
                 <asp:RadioButton ID="V3" Text="Satisfactory"  GroupName="venue" runat="server" />
             </td><td style="width: 94px">
                 <asp:RadioButton ID="V4" Text="Good" GroupName="venue" runat="server" />
             </td><td style="width: 155px">
                 <asp:RadioButton ID="V5" Text="Excellent"  GroupName="venue" runat="server" />
             </td></tr>
         <tr><td style="background-color:#151C47; color:white">Volunteers</td><td>
             <asp:RadioButton ID="Vol1" Text="Very Poor"  GroupName="vol" runat="server" />
             </td><td >
                 <asp:RadioButton ID="Vol2" Text="Poor"  GroupName="vol" runat="server" />
             </td><td>
                 <asp:RadioButton ID="Vol3" Text="Satisfactory" GroupName="vol" runat="server" />
             </td><td style="width: 94px">
                 <asp:RadioButton ID="vol4" Text="Good" GroupName="vol" runat="server" />
             </td><td style="width: 155px">
                 <asp:RadioButton ID="Vol5" Text="Excellent" GroupName="vol" runat="server" />
             </td></tr>
         <tr><td style="background-color:#151C47; color:white">Hospitality</td><td>
             <asp:RadioButton ID="H1" Text="Very Poor" GroupName="H" runat="server" />
             </td><td>
                 <asp:RadioButton ID="H2" Text="Poor" GroupName="H" runat="server" />
             </td><td>
                 <asp:RadioButton ID="H3" Text="Satisfactory" GroupName="H" runat="server" />
             </td><td style="width: 94px">
                 <asp:RadioButton ID="H4" Text="Good" GroupName="H" runat="server" />
             </td><td style="width: 155px">
                 <asp:RadioButton ID="H5" Text="Excellent" GroupName="H" runat="server" />
             </td></tr> 
        <tr><td style="background-color:#151C47; color:white">Course</td><td>
            <asp:RadioButton ID="c1" Text="Very Poor" GroupName="c" runat="server" />
            </td><td>
                <asp:RadioButton ID="c2" Text="Poor" GroupName="c" runat="server" />
            </td><td>
                <asp:RadioButton ID="c3" Text="Satisfactory" GroupName="c" runat="server" />
            </td><td style="width: 94px">
                <asp:RadioButton ID="c4" Text="Good" GroupName="c" runat="server" />
            </td><td style="width: 155px">
                <asp:RadioButton ID="c5"  Text="Very Good" GroupName="c" runat="server" />
            </td></tr>
         <tr><td style="background-color:#151C47; color:white">Registration</td><td>
             <asp:RadioButton ID="R1" Text="Very Poor" GroupName="R" runat="server" />
             </td><td>
                 <asp:RadioButton ID="R2" Text="Poor" GroupName="R" runat="server" />
             </td><td>
                 <asp:RadioButton ID="R3" Text="Satisfactory" GroupName="R" runat="server" />
             </td><td style="width: 94px">
                 <asp:RadioButton ID="R4" Text="Good" GroupName="R" runat="server" />
             </td><td style="width: 155px">
                 <asp:RadioButton ID="R5" Text="Excellent" Group="R" runat="server" />
             </td></tr> 
        <tr><td style="background-color:#151C47; color:white">Atmosphere</td><td>
            <asp:RadioButton ID="A1" Text="Very Poor" GroupName="A" runat="server" />
            </td><td>
                <asp:RadioButton ID="A2" Text="Poor" GroupName="A" runat="server" />
            </td><td>
                <asp:RadioButton ID="A3" Text="Satisfactory" GroupName="A" runat="server" />
            </td><td style="width: 94px">
                <asp:RadioButton ID="A4" Text="Good" GroupName="A" runat="server" />
            </td><td style="width: 155px">
                <asp:RadioButton ID="A5" Text="Excellent" GroupName="A" runat="server" />
            </td></tr> 
        <tr><td  colspan="6" style="align-items :center">
            <asp:Button ID="Button1"  runat="server" Text="Submit" CssClass="btn btn btn-primary" OnClick="Button1_Click" />
            </td></tr>
    </table>
       </asp:Panel>
                            <div class="panel-body">
                                
                            </div>
                        </div>
                    </div>
                </div>
   
</asp:Content>
