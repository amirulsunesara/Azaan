using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            this.Master.name.Text = Session["User"].ToString();
        }
        catch (Exception ex)
        {
            Response.Redirect("index.aspx");
        }
        if (!IsPostBack)
        {
            AdminDAL adal = new AdminDAL();
            int id = Convert.ToInt32(Session["aid"]);
            DataSet ds = adal.getDetails(id);
            DataTable dt = ds.Tables[0];
            DataRow dr = dt.Rows[0];
            txtEmail.Text = dr["email"].ToString();
            txtPassword.Text = "";
            txtCPass.Text = "";
            txtFname.Text = dr["admin_fname"].ToString();
            txtLname.Text = dr["admin_lname"].ToString();
            txtEmail.Enabled = false;
            txtFname.Enabled = false;
            txtLname.Enabled = false;
            txtPassword.Enabled = false;
            txtCPass.Enabled = false;
            btnSubmit.Visible = false;
        }

    }
    protected void Page_Init(object sender, EventArgs e)
    {
        this.Master.LogOutButton.Click += new EventHandler(LogoutButton_Click);
        this.Master.LBtn.ServerClick += new EventHandler(Messages_Click);
        this.Master.Profilee.ServerClick += new EventHandler(Profilee_Click);
    }
    protected void Profilee_Click(object sender, EventArgs e)
    {

        Response.Redirect("Profile.aspx");
    }

    protected void Messages_Click(object sender, EventArgs e)
    {

        Response.Redirect("Message.aspx");
    }
    protected void LogoutButton_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Session.Abandon();
        Response.Redirect("Index.aspx");
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        txtEmail.Enabled = true;
        txtFname.Enabled = true;
        txtLname.Enabled = true;
        txtPassword.Enabled = true;
        txtCPass.Enabled = true;
        btnSubmit.Visible = true;
        btnUpdate.Visible = false;
     

    }
      public bool isFormGood()
    {

        bool returnval = false;
       


        if (txtPassword.Text != txtCPass.Text)
        {
            returnval = false;
            lblNotify.Text = "Password Mismatched, Please Retype Password";
        }
        else
        {
            returnval = true;
        }
        if (txtPassword.Text.Length < 8 && txtCPass.Text.Length < 8)
        {
            returnval = false;
            lblPassword.Text = "Password Must Consist Minimum 8 Characters";
            lblCPassword.Text = "Password Must Consist Minimum 8 Characters";
        }
        else
        {
            returnval = true;
        }
      
        if (txtFname.Text.Length == 0)
        {
            returnval = false;
            lblFname.Text = "First Name is Required Field";
        }
        else
        {
            returnval = true;
        }
        if (txtLname.Text.Length == 0)
        {
            returnval = false;
            lblLname.Text = "Last Name is Required Field";
        }
        else
        {
            returnval = true;
        }
      
        if (txtEmail.Text.Length == 0)
        {
            returnval = false;
            lblEmail.Text = "Email is Required Field";
        }
        else
        {
            returnval = true;

        }
        if (txtPassword.Text.Length == 0)
        {
            returnval = false;
            lblPassword.Text = "Password is Required Field";
        }
        else
        {
            returnval = true;
        }
        if (txtCPass.Text.Length == 0)
        {
            returnval = false;
            lblCPassword.Text = "Password is Required Field";
        }
        else
        {
            returnval = true;
        }

        if (txtPassword.Text.Length < 8 || txtCPass.Text.Length < 8 || txtCPass.Text.Length == 0 || txtPassword.Text.Length == 0 || txtFname.Text.Length == 0 || txtLname.Text.Length == 0 )
        {
            returnval = false;
        }
        else
        {
            returnval = true;
        }


        return returnval;
    }
      public void doSignup()
      {
          Administrator a = new Administrator();
          AdminDAL ldal = new AdminDAL();
          if (isFormGood() == true)
          {
              a.fname = txtFname.Text;
              a.lname = txtLname.Text;

             a.email = txtEmail.Text;
              a.password = txtPassword.Text;
                   int id = Convert.ToInt32(Session["aid"]);
              ldal.UpdateAdmin(a , id );

              txtFname.Visible = false;
              txtLname.Visible = false;

              txtEmail.Visible = false;
              txtPassword.Visible = false;
              txtCPass.Visible = false;
              btnSubmit.Visible = false;

              lblFnamee.Visible = false;
              lblLnamee.Visible = false;

              lblEmaill.Visible = false;
              lblPasswordd.Visible = false;
              lblCPasss.Visible = false;
              cia.Visible = false;
              ld.Visible = false;
              lblSubmitted.Visible = true;

              lblSubmitted.Text = "Account details has been Submitted";
              btnUpdate.Visible = false;
          }
          else
          {
              Response.Write("Bad form");
          }


      }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        doSignup();
    }
}