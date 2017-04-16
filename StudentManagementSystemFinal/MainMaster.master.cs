using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MainMaster : System.Web.UI.MasterPage
{
    public Button LoginButton 
    {

        get 
        {

            return btnLogin;
        }
    
    }
  
    public void Page_Load(object sender, EventArgs e)
    {

    }
    public bool isFormGood()
    {
        bool returnval = false;
        if (txtEmail.Text.Length == 0)
        {
         
            lblAuth.Text = "Authentication Failed";

            returnval = false;

        }
        else
        {
           
            returnval = true;
        }
        if (txtPassword.Text.Length == 0)
        {

            lblAuth.Text = "Authentication Failed";

            returnval = false;


        }
        else
        {
         
            returnval = true;
        }
        if (txtEmail.Text.Length == 0 || txtPassword.Text.Length == 0)
        {

            lblAuth.Text = "Authentication Failed";
            returnval = false;
        }
        return returnval;
    }
    public void dologin()
    {
        LoginDAL ld = new LoginDAL();
        if (ld.isCorrectLoginInfoInstructor(txtEmail.Text, txtPassword.Text))
        {

            Response.Redirect("IDashboard.aspx");
        }
        else
        {


            lblAuth.Text = "Authentication Failed";


        }

        if (ld.isCorrectLoginInfoStudent(txtEmail.Text, txtPassword.Text))
        {

          Response.Redirect("SDashboard.aspx");
           
        }
        else
        {


            lblAuth.Text = "Authentication Failed";
           

        }
        if (ld.isCorrectLoginInfoAdministrator(txtEmail.Text, txtPassword.Text))
        {
           Response.Redirect("Dashboard.aspx");
        }
        else
        {


            lblAuth.Text = "Authentication Failed";

        }

      


    }

    public void btnLogin_Click(object sender, EventArgs e )
    {


        if (isFormGood())
        {
            dologin();
        }
        else 
        {
            lblAuth.Text = "Authentication Failed";
        }
    }
   
  
}
