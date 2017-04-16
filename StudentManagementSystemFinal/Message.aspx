<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="Message.aspx.cs" Inherits="Message" %>
<%@ MasterType VirtualPath="~/AdminMaster.master" %>
<asp:Content ID="Content500" ContentPlaceHolderID="Heading7" runat="Server">
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">Messages
            </h1>
            <ol class="breadcrumb">
                <li>
                    <i class="fa fa-dashboard"></i><a href="Dashboard.aspx">Dashboard</a>
                </li>
                <li class="active">
                    <i class="fa fa-inbox"></i>Messages
                </li>

            </ol>
        </div>
    </div>
</asp:Content>
<asp:Content ContentPlaceHolderID="Message" runat="Server">
    <div class="container">
        <div class="row">
            <div class="col-sm-3 col-md-2">
                <div class="btn-group">
                </div>
            </div>
            <div class="col-sm-9 col-md-10">
                <!-- Split button -->
                <div class="btn-group">
                </div>


                <!-- Single button -->
                <div class="btn-group">



                    <ul class="dropdown-menu" role="menu">
                    </ul>
                </div>

            </div>
        </div>
        <hr>
        <div class="row">
            <div class="col-sm-3 col-md-2">
                <asp:Button ID="btnCompose" runat="server" Text="Compose a message" CssClass="btn btn-success btn-sm btn-block" OnClick="btnCompose_Click" />
                <hr>
                <ul class="nav nav-pills nav-stacked">
                    <li>
                        <asp:Button ID="btnInbox" runat="server" Text="Inbox" CssClass="btn btn-primary" Width="120px" OnClick="btnInbox_Click" />
                    </li>

                    <li>
                        <asp:Button ID="btnSentMails" runat="server" Text="Sent Mails" Width="119px" CssClass="btn btn-default" OnClick="btnSentMails_Click" /></li>

                </ul>
            </div>
            <div class="col-sm-9 col-md-10">
           
                <ul class="nav nav-tabs">
                    <asp:Button ID="btnDelete" runat="server"  Text="Delete Selected" CssClass="btn btn-danger" OnClick="btnDelete_Click" />
                    <asp:Button ID="btnDelete2" runat="server" Text="Delete Selected" CssClass="btn btn-danger" OnClick="btnDelete2_Click" />
                    
                </ul>
                
                <br />
                <br />
             
                <div class="tab-content">
                    <div class="tab-pane fade in active" id="home">
                        <div class="list-group">
                            <asp:Label ID="lblNotify" runat="server" Text=""></asp:Label>
                            <asp:ScriptManager ID="ScriptManager1" 
                       runat="server" />
                             <asp:UpdatePanel ID="UpdatePanel1" 
                     UpdateMode="Conditional"
                     runat="server">
                                  <Triggers>
                       <asp:AsyncPostBackTrigger ControlID="btnDelete" />
                                          <asp:AsyncPostBackTrigger ControlID="btnDelete2" />
                                
                                       
                     </Triggers>
                                 <ContentTemplate>
                                     
                                     <asp:Label ID="lblEmpty" runat="server" Text="Inbox is Empty" ForeColor="Maroon" Font-Size="X-Large"></asp:Label>
                                     <asp:PlaceHolder ID="DBDataPlaceHolder" runat="server"></asp:PlaceHolder> 
                            <asp:GridView ID="gvMessage"  runat="server"  DataKeyNames="Id" AllowPaging="True" EnableViewState="False" Height="118px" Width="727px" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black "  OnRowDataBound="gvMessage_RowDataBound">
                                <Columns>
                                    <asp:TemplateField >
                                        <ItemTemplate >
                                            <asp:CheckBox ID="DeleteSelector" runat="server" />
                                         
                                        </ItemTemplate>
                                     
                                    </asp:TemplateField>
                                   
                                     
                                </Columns>
                                 <Columns>
                                    <asp:TemplateField >
                                        <ItemTemplate >
                      
                                            <asp:LinkButton ID="Reply" runat="server">Reply</asp:LinkButton>
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
                                     </ContentTemplate>
                                 </asp:UpdatePanel>
                        </div>
                    </div>


                </div>

                <div class="row-md-12">
                </div>
            </div>
        </div>
  </div>
</asp:Content>






