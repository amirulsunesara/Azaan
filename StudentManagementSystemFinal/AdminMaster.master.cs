using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
public partial class AdminMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
   
    
    }
    public LinkButton LogOutButton 
    {
        get 
        {
            return lbLogout;
        
        }
        
    
    }
    public  HtmlAnchor LBtn 
    {
        get
        {
            return msg;

        }
       
    
    }
    public HtmlAnchor Profilee
    {
        get
        {
            return pro;

        }


    }
    public Label name
    {
        get
        {

            return lblName;
        }

    }
    public void msg_Click(object sender, EventArgs e)
    {
        
        Response.Redirect("Message.aspx");
    }
    public void pro_Click(object sender, EventArgs e)
    {
       
        Response.Redirect("Profile.aspx");
    }
   
    public void lbLogout_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Session.Abandon();
        Response.Redirect("SignUpp.aspx");
    }
}
