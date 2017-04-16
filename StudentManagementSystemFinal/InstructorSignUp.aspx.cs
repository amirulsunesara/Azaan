using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InstructorSignUp : System.Web.UI.Page
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
        lblSubmitted.Visible = false;
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

   public bool isFormGood()
   {

       bool returnval = false;
       if (txtFname.Text.Length == 0)
       {
           returnval = false;
           lblFname.Text = "This is Required Field";

       }
       else
       {
           lblFname.Text = "";
           returnval = true;
       }
       if (txtLname.Text.Length == 0)
       {
           returnval = false;
           lblLname.Text = "This is Required Field";
       }
       else
       {
           lblLname.Text = "";
           returnval = true;
       }
       if (txtCell.Text.Length == 0)
       {
           returnval = false;
           lblCell.Text = "This is Required Field";
       }
       else
       {
           lblCell.Text = "";
           returnval = true;
       }
       if (txtTel.Text.Length == 0)
       {
           returnval = false;
           lblTel.Text = "This is Required Field";
       }
       else
       {
           lblTel.Text = "";
           returnval = true;
       }
       if (txtAddress.Text.Length == 0)
       {
           returnval = false;
           lblAddress.Text = "This is Required Field";
       }
       else
       {
           lblAddress.Text = "";
           returnval = true;
       }
       if (txtEmail.Text.Length == 0)
       {
           returnval = false;
           lblEmail.Text = "This is Required Field";
       }
       else
       {
           lblEmail.Text = "";
           returnval = true;
       }
       if (txtPassword.Text.Length == 0)
       {
           returnval = false;
           lblPassword.Text = "This is Required Field";
       }
       else
       {
           lblPassword.Text = "";
           returnval = true;
       }
       if (txtCPass.Text.Length == 0)
       {
           returnval = false;
           lblCPassword.Text = "This is Required Field";
       }
       else
       {
           lblCPassword.Text = "";
           returnval = true;
       }


       if (txtPassword.Text != txtCPass.Text)
       {
           returnval = false;
           lblPassword.Text = "Password Mismatched";
           lblCPassword.Text = "Password Mismatched";
       }
       else
       {

           returnval = true;
       }
       if (txtPassword.Text.Length < 8 && txtCPass.Text.Length < 8)
       {
           returnval = false;
           lblPassword.Text = "Invalid Password Length";
       }
       else
       {
           lblPassword.Text = "";
           returnval = true;
       }
       if (txtCell.Text.Length > 12 || txtCell.Text.Length < 11)
       {
           returnval = false;
           lblCell.Text = "Invalid Cell Phone no.";
       }
       else
       {
           lblCell.Text = "";
           returnval = true;
       }
       if (txtTel.Text.Length > 12 || txtTel.Text.Length < 8)
       {
           returnval = false;
           lblTel.Text = "Invalid Telephone No.";
       }
       else
       {
           lblTel.Text = "";
           returnval = true;
       }

       if (txtTel.Text.Any(char.IsLetter))
       {
           returnval = false;
           lblTel.Text = "Invalid Telephone No.";
       }
       else
       {

           returnval = true;
       }

       if (txtCell.Text.Any(char.IsLetter))
       {
           returnval = false;
           lblCell.Text = "Invalid Cell Phone no.";
       }
       else
       {

           returnval = true;
       }

       if (txtPassword.Text.Length < 8 || txtCPass.Text.Length < 8 || txtCPass.Text.Length == 0 || txtPassword.Text.Length == 0 || txtFname.Text.Length == 0 || txtLname.Text.Length == 0 || txtCell.Text.Length == 0 || txtTel.Text.Length == 0 || txtEmail.Text.Length == 0 || txtAddress.Text.Length == 0 || txtPassword.Text != txtCPass.Text || txtCell.Text.Any(char.IsLetter) || txtTel.Text.Any(char.IsLetter))
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
        SignUp su = new SignUp();
        InstructorsDAL ldal = new InstructorsDAL();
        if (isFormGood() == true)
        {
            su.Fname = txtFname.Text;
            su.Lname = txtLname.Text;
            su.Cell = txtCell.Text;
            su.Tel = txtTel.Text;
            su.Address = txtAddress.Text;
            su.Email = txtEmail.Text;
            su.Password = txtPassword.Text;
            ldal.addInstructor(su);

            txtFname.Visible = false;
            txtLname.Visible = false;
            txtCell.Visible = false;
            txtTel.Visible = false;
            txtAddress.Visible = false;
            txtEmail.Visible = false;
            txtPassword.Visible = false;
            txtCPass.Visible = false;
            btnSubmit.Visible = false;

            lblFnamee.Visible = false;
            lblLnamee.Visible = false;
            lblCelll.Visible = false;
            lblTell.Visible = false;
            lblAddresss.Visible = false;
            lblEmaill.Visible = false;
            lblPasswordd.Visible = false;
            lblCPasss.Visible = false;
            cia.Visible = false;
            ld.Visible = false;
            lblSubmitted.Visible = true;

            lblFname.Visible = false;
            lblLname.Visible = false;
            lblCell.Visible = false;
            lblTel.Visible = false;
            lblAddress.Visible = false;
            lblEmail.Visible = false;
            lblPassword.Visible = false;
            lblCPassword.Visible = false;
            cia.Visible = false;
            ld.Visible = false;
           
            lblSubmitted.Text = "Account has been Submitted";
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