<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="CurrentInstructors.aspx.cs" Inherits="CurrentInstructors" %>
<%@ MasterType VirtualPath="~/AdminMaster.master" %>
<asp:Content ID="Content14" ContentPlaceHolderID="Heading6" Runat="Server">
    <div class="row">
        <div class="col-lg-12" >
            <h1 class="page-header">Instructors
            </h1>
            <ol class="breadcrumb">
                <li>
                    <i class="fa fa-dashboard"></i><a href="Dashboard.aspx"> Dashboard</a>
                </li>
                <li class="active">
                    <i class="fa fa-mae"></i> Instructors
                </li>
                <li class="active"></i> Current Instructors
                </li>
            </ol>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content13" ContentPlaceHolderID="CurrentInstructors" Runat="Server">
       <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="btn btn-default" OnClick="btnDelete_Click"/><br /><br />
      <div style="text-align: center;">
       
          <asp:Label ID="lblNo" runat="server" Text="There are no Instructors Currently Registered" Font-Bold="True" Font-Size="X-Large" ForeColor="Maroon"></asp:Label>
          <asp:GridView ID="gvInstructors" runat="server" CssClass="table table-bordered table-hover table-responsive"   DataKeyNames="Id"
            AllowPaging="True" EnableViewState="False" Height="118px" Width="527px" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black"  >
               
              <Columns>
            <asp:TemplateField>
                    <ItemTemplate>
                        <asp:CheckBox ID="DeleteSelector" runat="server" />
                    </ItemTemplate>
               
                </asp:TemplateField>
                 
              </Columns>
              <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle  HorizontalAlign="Center"  VerticalAlign="Middle" CssClass="headerClass" BackColor="Black" Font-Bold="True" ForeColor="White" />
              <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
              <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" BackColor="White" />
           
              <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
              <SortedAscendingCellStyle BackColor="#F1F1F1" />
              <SortedAscendingHeaderStyle BackColor="#808080" />
              <SortedDescendingCellStyle BackColor="#CAC9C9" />
              <SortedDescendingHeaderStyle BackColor="#383838" />
            
          </asp:GridView>
        
    </div>
</asp:Content>