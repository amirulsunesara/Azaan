<%@ Page Title="" Language="C#" MasterPageFile="~/StudentMaster.master" AutoEventWireup="true" CodeFile="CourseRegistration.aspx.cs" Inherits="_Default" %>
<%@ MasterType VirtualPath="~/StudentMaster.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Heading1" Runat="Server">
     <div class="row">
                    <div class="col-lg-12">
                        <h1 class="page-header">
                           Workshops
                        </h1>
                        <ol class="breadcrumb">
                            <li>
                                <i class="fa fa-dashboard"></i>  <a href="SDashboard.aspx">Dashboard</a>
                            </li>
                            <li class="active">
                                <i class="fa fa-book"></i> Registration
                            </li>
                             <li class="active">
                                </i> Workshop Registration
                            </li>
                        </ol>
                    </div>
                </div>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="CourseRegistration" Runat="Server">
      <h3 id="heading1" runat="server">Workshop Registration</h3>
    <br />

    <asp:GridView ID="gvCourseRegistration" runat="server" CssClass="table  table-bordered table-responsive table-hover"   DataKeyNames="Course Id"
            AllowPaging="True" EnableViewState="False" Height="118px" Width="527px" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1" CellPadding="4" CellSpacing="2" ForeColor="Black"  >
               
              <Columns>
            <asp:TemplateField>
                    <ItemTemplate>
                        <asp:CheckBox ID="RegisterThis" runat="server" />
                    </ItemTemplate>
               
                </asp:TemplateField>
                 
              </Columns>
              <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle  HorizontalAlign="Center" VerticalAlign="Middle" CssClass="headerClass" BackColor="Black" Font-Bold="True" ForeColor="White" />
              <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
              <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" BackColor="White" />
            
              <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
              <SortedAscendingCellStyle BackColor="#F1F1F1" />
              <SortedAscendingHeaderStyle BackColor="#808080" />
              <SortedDescendingCellStyle BackColor="#CAC9C9" />
              <SortedDescendingHeaderStyle BackColor="#383838" />
            
          </asp:GridView>
     <asp:Button ID="btnRegister" runat="server" Text="Register" CssClass="btn btn-default" OnClick="btnRegister_Click"/><asp:Label ID="lblAlready" runat="server" Font-Bold="True" ForeColor="Red" ></asp:Label><br /><br />
    
</asp:Content>
