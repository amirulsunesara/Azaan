using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


public partial class AddCourse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            this.Master.name.Text = Session["User"].ToString();
        }
        catch(Exception ex)
        {
            Response.Redirect("index.aspx");
        }
        if (!IsPostBack)
        {
            InstructorsDAL idal = new InstructorsDAL();
            DataSet ds = idal.getAllInstructors();
            ddIname.DataSource = ds;
            ddIname.DataValueField = "Instructor_id";
            ddIname.DataTextField = "Instructor name";

            ddIname.DataBind();
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
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Course c = new Course();
        c.CourseName = txtCname.Text;
       
       CourseDAL id = new CourseDAL();
       string value = ddIname.SelectedValue;
       id.addCourse(c, value);
       lblFname.Text = "Course has been Succesfully Assigned";
       lblFname.ForeColor = System.Drawing.Color.Green;

       name.Visible = false;
       iname.Visible = false;
       lblLname.Visible = false;
       txtCname.Visible = false;
       ddIname.Visible = false;
       btnSubmit.Visible = false;
    }

    protected void ddIname_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}