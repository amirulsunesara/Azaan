using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Text;
using System.Data;
using System.Web.UI.WebControls;

public partial class Enrollment : System.Web.UI.Page
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
            StringBuilder htmlTable = new StringBuilder();
            RegistrationDAL rdal = new RegistrationDAL();


            DataSet ds = rdal.getStudent();


            htmlTable.Append("<table border='1' id='Table1' class='table table-bordered table-hover table-responsive' width='500px' height='80'>");
            htmlTable.Append("<tr style='background-color:#591919; color: White; '><th  style='text-align:center'>Course ID</th><th style='text-align:center'>Course Name</th><th style='text-align:center'>Total Enrolled Students</th></tr>");
            int j = 1000;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                int cid = Convert.ToInt32(ds.Tables[0].Rows[i]["Course_id"]);
                int count = rdal.getcount(cid);
                htmlTable.Append("<tr style='color: black;'>");
                htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["Course_id"] + "</td>");
                htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["Course_Name"] + "</td>");
                htmlTable.Append("<td>" + count + "</td>");




                htmlTable.Append("</tr>");



            }
            htmlTable.Append("</table>");
            DBDataPlaceHolder.Controls.Add(new Literal { Text = htmlTable.ToString() });
            lblNo.Visible = false;
            if (ds.Tables[0].Rows.Count == 0)
            {
                DBDataPlaceHolder.Visible = false;
                lblNo.Visible = true;
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