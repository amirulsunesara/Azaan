<%@ Page Title="" Language="C#" MasterPageFile="~/StudentMaster.master" AutoEventWireup="true" CodeFile="SecuredMarks.aspx.cs" Inherits="_Default" %>
<%@ MasterType VirtualPath="~/StudentMaster.master" %>
<asp:Content ID="Content3" ContentPlaceHolderID="Heading2" Runat="Server">
     <div class="row">
                    <div class="col-lg-12">
                        <h1 class="page-header">
                            Courses
                        </h1>
                        <ol class="breadcrumb">
                            <li>
                                <i class="fa fa-dashboard"></i>  <a href="SDasboard.aspx">Dashboard</a>
                            </li>
                            <li class="active">
                                <i class="fa fa-book"></i> Workshop Progress
                            </li>
                             <li class="active">
                                </i> View Secured Marks
                            </li>
                        </ol>
                    </div>
                </div>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="SecuredMarks" Runat="Server">
      <h3>View Secured Marks</h3>
    <br />
  <b>  </b><asp:DropDownList ID="ddCourse" CssClass="dropdown-menu-left" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddCourse_SelectedIndexChanged" Height="23px" Width="157px"></asp:DropDownList>
  <br /><br />   <asp:Label ID="lblMarks" runat="server" ForeColor="#000066" Font-Size="X-Large"></asp:Label>
       
</asp:Content>
