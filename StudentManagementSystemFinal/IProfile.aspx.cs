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
            InstructorsDAL sdal = new InstructorsDAL();
            int id = Convert.ToInt32(Session["Marks_Key"]);
            DataSet ds = sdal.getDetails(id);
            DataTable dt = ds.Tables[0];
            DataRow dr = dt.Rows[0];
            txtEmail.Text = dr["instructor_email"].ToString();
            txtPassword.Text = "";
            txtCPass.Text = "";
            txtFname.Text = dr["instructor_fname"].ToString();
            txtLname.Text = dr["instructor_lname"].ToString();
            txtTel.Text = dr["telephone"].ToString();
            txtCell.Text = dr["instructor_cellno"].ToString();
            txtAddress.Text = dr["address"].ToString();
            txtTel.Enabled = false;
            txtCell.Enabled = false;
            txtAddress.Enabled = false;
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

        Response.Redirect("IProfile.aspx");
    }

    protected void Messages_Click(object sender, EventArgs e)
    {

        Response.Redirect("IMessage.aspx");
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
        txtTel.Enabled = true;
        txtCell.Enabled = true;
        txtAddress.Enabled = true;
        btnUpdate.Visible = false;


    }
    public bool isFormGood()
    {

        bool returnval = false;



        if (txtPassword.Text != txtCPass.Text)
        {
            returnval = false;
            lblNotify.Text = "        Password Mismatched, Please Retype Password";
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
        if (txtCell.Text.Length > 12 || txtCell.Text.Length < 11)
        {
            returnval = false;
            lblCell.Text = "Invalid Cell Phone Number Length";
        }
        else
        {
            returnval = true;
        }
        if (txtTel.Text.Length > 12 || txtTel.Text.Length < 8)
        {
            returnval = false;
            lblTel.Text = "Invalid Telephone Number Length";
        }
        else
        {
            returnval = true;
        }

        if (txtTel.Text.Any(char.IsLetter))
        {
            returnval = false;
            lblTel.Text = "Invalid Telephone Number";
        }
        else
        {
            returnval = true;
        }

        if (txtCell.Text.Any(char.IsLetter))
        {
            returnval = false;
            lblCell.Text = "Invalid Cell Phone Number";
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
        if (txtCell.Text.Length == 0)
        {
            returnval = false;
            lblCell.Text = "Cell is Required Field";
        }
        else
        {
            returnval = true;
        }
        if (txtTel.Text.Length == 0)
        {
            returnval = false;
            lblTel.Text = "Telephone is Required Field";
        }
        else
        {
            returnval = true;
        }
        if (txtAddress.Text.Length == 0)
        {
            returnval = false;
            lblAddress.Text = "Address is Required Field";
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
        SignUp a = new SignUp();
        InstructorsDAL sdal = new InstructorsDAL();
        if (isFormGood() == true)
        {
            a.Fname = txtFname.Text;
            a.Lname = txtLname.Text;
            a.Tel = txtTel.Text;
            a.Cell = txtCell.Text;
            a.Address = txtAddress.Text;
            a.Email = txtEmail.Text;
            a.Password = txtPassword.Text;

            int id = Convert.ToInt32(Session["Marks_Key"]);
            sdal.UpdateInstructor(a, id);

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
            lblNotify.Visible = false;
            lblCell.Visible = false;
            lblPassword.Visible = false;
            lblCPassword.Visible = false;
            lblAddress.Visible = false;
            lblFname.Visible = false;
            lblLname.Visible = false;
            lblTel.Visible = false;
            lblEmail.Visible = false;

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