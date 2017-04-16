using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class ViewStudents : System.Web.UI.Page
{
    Student std = new Student();
    StudentDAL sdal = new StudentDAL();
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
        lblEmpty.Visible = false;
        DataSet ds = sdal.getStudents();
        gvStudents.DataSource = ds;
        gvStudents.DataBind();

    }

   

    protected void btnSearch_Click1(object sender, EventArgs e)
    {
        std.Search = txtSearch.Text;
        DataSet ds = sdal.getSearchStudents(std.Search);
        gvStudents.DataSource = ds;
        gvStudents.DataBind();
        if (ds.Tables[0].Rows.Count == 0)
        {
            lblEmpty.Visible = true;

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
}